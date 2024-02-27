Binary|Decimal|Hexadecimal|
-----|-----|-----|
0000|0|0
0001|1|1
0010|2|2
0011|3|3
0100|4|4
0101|5|5
0110|6|6
0111|7|7
1000|8|8
1001|9|9
1010|10|A
1011|11|B
1100|12|C
1101|13|D
1110|14|E
1111|15|F
# Note
Hexadecimal is useful for providing a short hand for binary that is easer then decimal.
e.g.8 bit byte has values ranging from 00000000 to 11111111 (0 -> 255 Decimal) can be represented as 00 to FF in hexadecimal
has 0<sub>16

### Example Table
PlaceValue|Binary|Decmal|
-------|-------|-------|
1|0|0|
2|0|0|
4|0|0|
8|0|0|
16|0|0|
32|0|0|
64|0|0|
128|0|0|
256|0|0|
512|0|0|
1024|0|0|
2048|0|0|

Finished Result|
-------|
0<sub>10|
0<sub>2|

### Example for Whole number

PlaceValue|Binary|Decmal|
-------|-------|-------|
1|0|0|
2|1|2|
4|1|6|
8|0|0|
16|1|22|
32|0|0|
64|1|86|
128|1|214|
256|0|0|
512|0|0|
1024|0|0|
2048|0|0|


Finished Result|
-------|
214<sub>10|
11010110<sub>2|

### Example for Decimal number

PlaceValue|Binary|Decmal|
-------|-------|-------|
1|1|1|
2|0|0|
4|0|0|
8|1|9|
16|0|0|
32|0|0|
64|0|0|

PlaceValue|Binary|Decmal|
-------|-------|-------|
.1|0|0|
.2|1|.2|
.4|0|0|
.8|0|0|

Expected Result|
-------|
9.2<sub>10|
1001.01<sub>2|

Actual Result|
-------|
9.2<sub>10|
1001.0011 0011 etc et|

a decent algorithmn for figuring out what the decimal place is in binary is timesing somthing by 2 and rounding down to the whole number. 
then timesing the left over by 2 until theres nothing left often you cant as its imprecise.
e.g.

.2 * 2 = 0.4 = 0

.4 * 2 = 0.8 = 0

.8 * 2 = 1.6 = 1

.6 * 2 = 1.2 = 1

.2 * 2 = 0.4 = 0

etc etc.

# Note
Fraction|Base|Positional Notation|Rounded to 4SF|Rounded as Fraction|Rounding Error
-------|-------|-------|-------|-------|-------|
1/10|10|0.1|0.1|1/10|0|
1/3|10|0.3|0.3333|3333/10000|1/30000|
1/2|2|0.1|0.1|1/2|0|
1/10|2|0.00011|0.0001|1/16|3/80|

this is how you get a rounding error from writing down 0.1 and run it through interpreter/compiler. computers tend to cut off after 23 or 52 binary digits rather than 4. But the error is *still* there and ***will*** cause problems.
this is also what single (32) and double (64) bit things are. 

Format|Total Bits|Significand|Expoent Bits|Smallest Number|Largest Number
-------|-------|-------|-------|-------|-------|
Single Precision|32|23 + 1 sign|8| ca 1.2 * 10<sup>-38| ca 3.4 * 10<sup>38|
Double Precision|64|52 + 1 sign|11| ca 2.2 * 10<sup>-308| ca 2.2 * 10<sup>308|

