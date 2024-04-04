## MATRIX
A matrix is an array of numbers. \
![matrix-example](https://www.mathsisfun.com/algebra/images/matrix-example.svg) \
To apply a scalar to a matrix multiply each element by the scalar.\
![matrix-multiply-constant](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/16f4ff79-0e2a-47a3-830b-4aaca09e90b5)\
To multiply a matrix by another matrix we do a [Dot Product](Mathmatics%201/Dot%20Product.md) \
Works the same as before but with matrices theres an extra step.\
You go by *FIRST* row and *FIRST* column then *FIRST* row and *SECOND* column\
![matrix-multiply-a](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/602550cc-de77-45a7-adb7-c3848a81ee9d)\
![matrix-multiply-b](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/4b2b40c2-97eb-429e-88a5-e47851ee81ef)

---

## ROWS AND COLUMNS
When you are multiplying matrices of varying columns.\
the **COLUMNS OF THE FIRST MATRIX** ***MUST EQUAL*** the number of **ROWS OF THE SECOND MATRIX**
and the result will have the same number of **ROWS** as the ***FIRST*** matrix and the number of **COLUMNS** as the ***SECOND*** matrix
![matrix-multiply-ex1b](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/1bfb9233-dd2e-4880-872e-11345124ed2e)\
1x3 by 3x4 results in a 1x4\
![matrix-multiply-rows-cols](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/abfaf6b0-872d-4a22-9a9b-931f2e55ecf9)

---

## Determinate
like a number has a reciprocal\
![reciprocal-reciprocal](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/05746dcc-b02b-4245-8645-0a69b33478d1) \
a matrix has an inverse\
![matrix-inverse-both](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/7c777330-f987-45ee-994c-26882000f236) \
we write $A^-1$ instead of $1/A$ beceause we dont divide by a matrix. 

#### Similarities

when we multiply a number by its reciprocal we get 1: \
$8 * 1/8 = 1$ \
when we multiply a matrix by its inverse we get the ***identity matrix*** (1 for matrices) \
$A * A^-1 = I$ 

---

## Identity Matrix
We just mentioned "IDENTITY MATRIX" as the matrix equivalent of the number "1" \
It is "Square" (Same number of rows as columns) \
Has 1 on diagon and 0 everywhere else. \
Its symbolized by the capital letter $I$. \
can be any size. \
![matrix-identity](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/e90be871-a823-40fd-8432-c8041b4b464c) \
The inverse of A is A^-1 only when: \
$A A^-1 = A^-1 A = I$ \
sometimes there is *no inverse at all*

## 2X2 Example
To calculate an inverse you \
1. Swap teh positions of a and d
2. Put negatives infront of b and c
3. and divide everything by ad-bc \
   3.1 ad-bc is called the [determinant](https://www.mathsisfun.com/algebra/matrix-determinant.html) \
![matrix-inverse-2x2](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/5efda623-aab6-4e3e-bbdd-3f6d02c5a7fc) \
Here is an example of working it out. \
![matrix-inverse-2x2-ex1](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/dbe1b3b7-0a92-40af-98e5-9cd555e64036) \
after doing this we now have the inverse of our first matrix to check this we need to find the **Indentity Matrix** \
by multiplying the original with the inverse we should get the **Identity Matrix**\
![matrix-inverse-2x2-ex2](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/35b7c04d-ecb3-417a-abdb-6947ff2214d0)

## But Y 

 We need to do this because you **CAN'T DIVIDE MATRICES.** \
**But** we can **MULTIPLY** an inverse to do the same thing. \
Similarly to how you can solve number division problems by finding the **reciprocal**. \
$10 / 2 = 5$ \
the reciprocal of 2 is .5 \
$10 * 0.5 = 5$ 

---
Same can be done with matrices: \
We want to find matrix X, and we know matrix A and B 

$XA = B$

it would be nice to divide both sides by A (X=B/A) **but we can't divide** \
We can **multiply** though. \
so we can multiply both sides by A^-1! \
$XAA^-1 = BA^-1$ \
and we know $AA^-1 = I$ \
$XI = BA^-1$ \
We can remove $I$ (for the same reason we can remove 1 from 1x = ab for numbers) \
$X = BA^-1$ \
and we got our answer (assuming we can calculate A^-1) 
