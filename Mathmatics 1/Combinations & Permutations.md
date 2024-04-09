# Combinations & Permutations
In english the word "combination" can sometimes care about the order of things. \
**But** in mathematics there is more ***Precise*** language. \
When order ***DOESN'T MATTER***, it is a *Combination*. \
Wehn order ***DOES MATTER***, it is a *Permutation*. \
In other words. \
*A PERMUTATION IS AN **ORDERED** COMBINATION*

---

## Permutations

There are two main types of permutation: 
1. **Repetition is Allowed**: like a combination lock, the answer could be "222". 
2. **No Repetition**: Like the first three people in a race. You can't be first *and* second.

### Permutations with Repetition.
These ones are simple. \
When a thing has ***N*** different types we have ***N*** choices each time.\
E.g. choosing 3 things, the permutations are: 

**N x N x N** (*N multipled 3 times*) 

or more generally: choosing **R** of something that has **N** types. 

**N x N x ... (R times)** 

(there are **N** possibilities for the *first* choice, THEN there are **N** possibilities for the seconds etc etc.) \
Which is easy to write down using an exponent of **R**:

**N x N x ... (R times)**  = **N^R**

i.e. Combination with 10 numbers to choose from with 3 slots.

**10 × 10 × ... (3 times) = 10^3 = 1,000 permutations**

The formula for Permutations with Repetition is just.

***N^R***
(where **n** is the number of things to choose from, and we choose **r** of them, repetition is allowed, and order matters.)

### Permutations **WITHOUT** Repetition
We tend to **reduce** the number of available choices each time. \
e.g. what order could 16 pool balls be in? \
after choosing number "16" we **CAN'T** choose it again. \
So our first choice has 16 possibilities, second has 15, then 14, 13 etc etc \
The total permutations are: \
**16 × 15 × 14 × 13 × ... = 20,922,789,888,000**

But maybe we don't want to choose all of them just *3 pool balls*:
**16 × 15 × 14 = 3,360** \
Or:
There are 3,360 ways that 3 pool balls could be arranged out of 16 balls.

***Without repetition our choices get reduced each time***
Mathematically this is done with the "Factorial Function"! \
Which just means to multiply a series of descending natural numbers.
i.e.
4! = 4 × 3 × 2 × 1 = 24 \
7! = 7 × 6 × 5 × 4 × 3 × 2 × 1 = 5,040 \
1! = 1
(Note: it is generally agreed that 0! = 1. It may seem funny that multiplying no numbers together gets us 1, but it helps simplify a lot of equations.)

So when we want to select **ALL** of the pool balls the permutations are:

16! = 20,922,789,888,000 \ 
But when we want to select just 3 we don't want to multiply after **14**. \
How do we do that using factorials? \
*We divide by **13!***

16 × 15 × 14 × 13 × 12 × ... \
-----|-----|----|-----|-----|---- \
                13 × 12 × ... \
-----|-----|----|-----|-----|---- \
=  16 × 15 × 14

This cancels out 13 x 12 x ... leaving only 16 x 15 x 14. \
This formula is written: \
***n!/(n-r)!*** \
(where n is the number of things to choose from,
and we choose r of them,
no repetitions,
order matters.)

i.e. the "order of 3 out of 16 pool balls" is: \
16!/(16-3)! = 16!/13! = 20,922,789,888,000/6,227,020,800 = 3,360

**NOTE**: Instead of writing the whole formula, people tend to use different notations such as these: \
P(n,r) = <sup>10</sup>P<sub>2</sub>

#### Further Reading.
https://www.mathsisfun.com/combinatorics/combinations-permutations.html
