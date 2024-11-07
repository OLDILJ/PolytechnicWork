### Subnet Table
128|64|32|16|8|4|2|1
---|--|--|-|-|-|-|-
128|192|224|240|248|252|254|255
/25|/26|/27|/28|/29|/30|/31|32
0|0|0|0|0|0|0|0

## Part 1: Devlop the IPv4 Addressing Scheme
|Number Of Subnets|
|-|
|5|

***ALWAYS -2 WHEN CALCULATING Host Count BLOCK***

5 subnets needed

4 > 5 > **8**

3 bits needed

Base Address: 192.168.25.128/25

Take 3 bit for 8 subnets

192.168.25.128/28

OctetView:
|N|S|S|S|H|H|H|H|
-|-|-|-|-|-|-|-|
1|0/1|0/1|0/1|0|0|0|0|

/28 -> decimal = 240

subnet mask = 255.255.255.240

Max Usable Subnets = 8

Max Number of Usable Hosts = 2^4 = 16

* remember to start calculating subnet net address from the current base address

i.e xxx.xxx.xxx.128 start incrementing at 128

2^4 = 16

Current one goes up in blocks of 16

### Subnet Addressing

|Subnet Number|Network Address|First Usable Host|Last Usable Host|Broadcast Address|
|-|-|-|-|-
|A|192.168.25.128|.129|.142|.143|
|B|192.168.25.144|.145|.158|.159|
|C|192.168.25.160|.161|.176|.177|
|D|192.168.25.178|.179|.192|.193|
|E|192.168.25.194|.195|.208|.209|
|F|192.168.25.210|.211|.224|.225|
|G|192.168.25.226|.227|.238|.239|
|H|192.168.25.240|.241|.254|.255|

### IP Address Info

|Device|IP address|Subnet Mask|Gateway|Points|
|-|-|-|-|-
|PC-A|192.168.25.129|.240|192.168.25.142|
|R1-G0/0|192.168.25.142|.240|N/A|
|R1-G0/1|192.168.25.158|.240|N/A|
|S1|192.168.25.157|.240|N/A|
|PC-B|192.168.25.145|.240|192.168.25.158|


