## Polar Cartesian Coordinates
Cartesian Coordinates we mark a point by **how far along** and **how far up it is** \
![Coordinates-Cartesian](https://www.mathsisfun.com/geometry/images/coordinates-cartesian.svg) 

With Polar Coordinates we mark a point by **how far away**, and **what angle it is** \
![coordinates-polar](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/164dc094-eda1-42a8-9a5e-c2e9c9d1d374)

### Cartesian to Polar
When we know a point in cartesian (x,y) and we want it in polar (r,θ) we solva a **right angle triangle** with **two** known sides. \
![coordinates-to-polar](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/8b36cfff-28e6-44ca-a652-650373868a7c)

We first use tangent to get the hypotenuse \
R^2 = 12^2 + 5^2 \
r = sqrt(12^2 + 5^2) \
r = sqrt (144 + 25) \
r = sqrt (169) = 13 

Then we use SohCah**Toa** to find the angle
tan(θ) = 5/12 \
θ = tan^-1(5/12) = 22.6 (rounded) 

The point 12,5 is 13,22.6 in polar

##### Note
Some calculators may give the wrong value for tan^-1() when x or y are negative.

### Polar to Cartesian
when we know a point in polar (r,θ) and we want it in cartesian (x,y) \
We solve a **right triangle** with a known **long side** and **angle** \
![coordinates-to-cartesian](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/abe8c0c3-eaa4-48ec-9389-a5c5d7feed9a)

First we solve for x \
cos(22.6) = x / 13 \
x = 13 * cos(22.6) \
x = 12.002 (rounded) 

Then we solve for y \
sin(22.6) = y/13 \
y = 13 * sin(22.6) \
y = 4.996 (rounded) 

### Negatives
Before I mentioned how some calculators give the wrong value when x or y are negative.

When we include negative values, the x and y axes divide the space into 4 pieces: \
![cartesian-quadrants](https://github.com/OLDILJ/PolytechnicWork/assets/161396140/d7b454d6-e029-46a7-a93c-e2e9ccf42f2b) \
When converting polar to cartesian it all works fine \
e.g. \
(12, 195) in cartesian \
x = 12 * cos(195) \
x = 12 * -0.9659... \
x = -11.59 (rounded)

y = 12 * sin(195) \
y = 12 * -0.2588... \
y = -3.11 (rounded)

so the point is at (-11.59, -3.11) which is in quardrant 3

But when converting **Cartesian to Polar**
the calculator can give the wrong value of tan^-1 \
It all depends what quadrant the point is in.

Quadrant 1: tan^-1 = calculator value
Quadrant 2: tan^-1 = calculator value + 180
Quadrant 3: tan^-1 = calculator value + 180
Quadrant 4: tan^-1 = calculator value + 360

e.g.
p = (-3,10)
P is in **Quardrant 2**
r = sqrt((-3)^ + 10^2)
r = sqrt(109) = 10.4 (rounded)

θ = tan^-1(10/-3)
θ = tan^-1(-3.33....)
the calculator value for tan^-1(-3.333) \
The rule for Quadrant 2 is add 180 to the calculator value
θ = -73.3 + 180 = 106.7
the polar for (-3, 10) are (10.4, 106.7)
