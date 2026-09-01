## Pt 1 (10%):

### Xen Setup:

### dom0:

#### Hypervisor:

#### Toolstack:

#### Boot To Xen:


### Bridge

#### Network evidence:

#### Guest Bridge:

#### show ssh working:


## Pt 2 (15%):

### QEMU:

#### QEMU OS Setup:

wget https://cloud.debian.org/images/cloud/bookworm/20260821-2577/debian-12-generic-amd64-20260821-2577.qcow2

qemu-img create -F qcow2 -b debian-12-generic-amd64-20260821-2577.qcow2 -f qcow2 disk-deb12-cloud-u1.qcow2 4G 
this creates a qemu image called disk-deb12-cloud-u1 that can grow up to 4G via qcow2 format (qcow2 delays allocation until its actually needed making the 20G act as a limiter instead of a hard size.) with debian-12 generic installed onto the image.

qemu-img create -f raw disk-swap.img 1G
this creates a disk-swap image for the xen cfg


### Guest Domains (2):

#### Xen QEMU config:
```
## NAME - TYPE
name = 'deb12-cloud1'

# type of guest - here Hardware Virtual Machine
type = 'hvm'
boot = 'c'

## CPU - RAM
vcpus = 2
memory = 2048

## DISKs
disk = [
    '/home/hogan/xenVMDom/disk-deb12-cloud-u1.qcow2,qcow2,xvda',
    '/home/hogan/xenVMDom/disk-swap.img,,xvdb',
]

## NETWORK
# if you don't set a MAC address for a vif, xl will set a new one each boot,
# so adjust your guest network config accordingly
vif = [
       'bridge=xenbr0,mac=90:b1:1c:83:14:9f,vifname=deb-cloud0'
]

on_poweroff = 'destroy'
on_reboot = 'restart'
on_crash = 'restart'

serial = 'pty'

```
#### Guest QEMU Active:
![alt text](image.png)

![alt text](image-1.png)

#### Shutdown/restart and guest recovery Management
![alt text](image-2.png)
![alt text](image-3.png)

#### Troubleshooting notes.
A lot of time was spent debugging the cfg file. I ended up sifting through xen logs until I figured out that I messed up the pathing in the initial qemu-img create.
I moved everything over to a new directory and rebased the qcow2 file and it worked.
qemu-img rebase -u -b /home/hogan/xenVMDom/debian-12-generic-amd64-20260821-2577.qcow2   /home/hogan/xenVMDom/disk-deb12-cloud-u1.qcow2



## Pt 3 (15%): 

### Automation script for pt 2:
``
#!/bin/bash

# $1 = clone name and directory
# $2 = clone MAC address suffix

set -euo pipefail

vg="ubuntu-vg"
srcVol="lab2_1_vol"
# removing hard coded sections for readability

usage() {
        echo "usage: $0 <guestName> <macSuffix> [size]" >&2
        echo "guestName: letters, numbers, dashes, and underscores no special characters; Additionally name cannot be all numbers" >&2
        echo "macSuffix: two hexdigits" >&2
        echo "size: optional snapshot size defaults to 1Gb" >&2
        exit 1
}

if [[ $# -lt 2 || $# -gt 3 ]]; then
        usage
fi

# validation checks if we have less then 2 arguments or more then 3 arguments. If we do then quit out and call usage.
guestName="$1"
macSuffix="$2"
size="${3:-1G}"

# Validation Regex Bash has different syntax
if [[ ! "$guestName" =~ ^[A-Za-z0-9_-]+$ ]]; then
    echo "ERROR: guest name '$guestName' is invalid — use letters, numbers, dashes, and underscores, no special characters." >&2
    exit 1
fi

if [[ "$guestName" =~ ^[0-9]+$ ]]; then
    echo "ERROR: guest name '$guestName' cannot be purely numeric, xl list treats an all-digit name as a domain ID." >&2
    echo "       Include at least one letter, dash, or underscore (e.g. 'vm32' instead of '32')." >&2
    exit 1
fi

if [[ ! "$macSuffix" =~ ^[0-9A-Fa-f]{2}$ ]]; then
    echo "ERROR: mac suffix '$macSuffix' is invalid — expected exactly two hex digits, e.g. 0a." >&2
    exit 1
fi

if [[ ! "$size" =~ ^[0-9]+[MG]$ ]]; then
    echo "ERROR: size '$size' is invalid — expected a number followed by M or G, e.g. 1G." >&2
    exit 1
fi

diskPath="/dev/${vg}/${guestName}"


if lvs "${vg}/${guestName}" &>/dev/null; then
    echo "ERROR: logical volume ${vg}/${guestName} already exists. Refusing to overwrite." >&2
    echo "       Remove it first with: lvremove ${vg}/${guestName} Or use cleanup script." >&2
    exit 1
fi

if xl list "$guestName" &>/dev/null; then
    echo "ERROR: a Xen domain named '$guestName' is already running. Refusing to overwrite." >&2
    exit 1
fi
modprobe dm-snapshot
#ensures that lvm snapshot can run properly, only has to run once per boot.

cfgFile="$(mktemp /tmp/clone-"${guestName}"-XXXXXX.cfg)"
trap 'rm -f "$cfgFile"' EXIT
# Create a cfg file then delete the file WHENEVER the script exits


echo "creating ${size} snapshot '${guestName}' of ${vg}/${srcVol}..."
if ! lvcreate -s -L "$size" -n "$guestName" "/dev/${vg}/${srcVol}"; then
    echo "ERROR: lvcreate failed — no guest was started." >&2
    exit 1
fi

cat > "$cfgFile" <<EOF
name = "$guestName"
memory = 512
vcpus = 1

bootloader = "/usr/lib/xen-4.11/bin/pygrub"

disk = [
    'phy:${diskPath},xvda,w'
]

vif = [
    'mac=00:16:3e:00:00:${macSuffix},bridge=xenbr0'
]

on_poweroff = 'destroy'
on_reboot = 'restart'
on_crash = 'restart'
EOF

echo "starting guest '${guestName}'..."
if ! xl create "$cfgFile"; then
    echo "ERROR: xl create failed. Rolling back the snapshot so re-runs aren't blocked." >&2
    lvremove -f "${vg}/${guestName}" &>/dev/null || \
        echo "WARNING: automatic rollback of ${vg}/${guestName} also failed — remove it manually." >&2
    exit 1
fi


if xl list "$guestName" &>/dev/null; then
    echo "guest '${guestName}' is running (MAC 00:16:3e:00:00:${macSuffix}, disk ${diskPath})."
    xl list "$guestName"
else
    echo "ERROR: xl create returned success but '${guestName}' is not listed as running." >&2
    exit 1
fi

##



``

## Pt 4 (15%):

### Ip forwarding + iptables

#### Presistent nat rules:

#### Reversibility:

#### Parameterized interface name:


## Pt 5 (20%):

### Deploy Apache On Guest 1:

### Deploy SQL on Guest 2:

### Deploy webpage with both guests talking to each other:

## Pt 6 (10%):

### Evaluate QEMU VS LVM
