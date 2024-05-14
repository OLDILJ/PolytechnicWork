# Random Numbers

 * Fully *  random numbers are impossible to algorithmically create.
However we can make appoximations that are good enough if our needs are not crucial.


### Random Number Generation
To prime software RNGs we begin with a "Seed Value" This can be any number

#### Linear Congruential Method
X<sub>i</sub> = (a x <sub>i-1</sub> + c) mod m
X is the seed value
a,c are the parameters provided to you

We can only trust this method to generate √m number of "Random" numbers.
We can take the output of one operation as the input for the next operation.

##### Example
X<sub>i</sub> = (a x <sub>i-1</sub> + c) mod m
x = 1, a = 9, c = 11, mod 16 (√16 = 4 potentially usable iterations)

(9 * x + 11) mod 16

(9 * 1 + 11) mod 16 = (9 + 11) mod 16 = 4
(9 * 4 + 11) mod 16 = (36 + 11) mod 16 = 15
(9 * 15 + 11) mod 16 = (135 + 11) mod 16 = 2
(9 * 2 + 11) mod 16 = (18 + 11) mod 16 = 13
(9 * 13 + 11) mod 16 = (117 + 11) mod 16 = 0
(9 * 0 + 11) mod 16 = (11) mod 16 = 11
