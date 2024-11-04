### Subnet Table
128|64|32|16|8|4|2|1
---|--|--|-|-|-|-|-
128|192|224|240|248|252|254|255
/25|/26|/27|/28|/29|/30|/31|32
0|0|0|0|0|0|0|0

## Part 1: Devlop the IPv4 Addressing Scheme
Subnet|Number Of Hosts
-|-
Subnet A| 15 Hosts
Subnet B| 12 Hosts

***ALWAYS -2 WHEN CALCULATING SUBNET BLOCK***

15 > 12

14 > 15

30 > 15

(16-2) > 15 > (**32**) 

in blocks of 32


Base Address: 192.168.25.0/26

Take 1 bit for 2 subnets

192.168.25.0/27

OctetView:
|N|N|S|H|H|H|H|H|
-|-|-|-|-|-|-|-|
0|0|0/1|0|0|0|0|0|

/27 -> decimal = 224

subnet mask = 255.255.255.224

Max Usable Subnets = 2

Max Number of Usable Hosts = 2^5 = 32

|Subnet Number|Network Address|First Usable Host|Last Usable Host|Broadcast Address|
|-|-|-|-|-
|A|192.168.25.0|.1|.30|.31|
|B|192.168.25.32|.31|.62|.63|
