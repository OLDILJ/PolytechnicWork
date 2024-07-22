#### Q1: 
    Explain in plain English what this method does

    public static void Mystery(ref int number1, ref int number2)
    {
        int temp;
        temp = number1;
        number1 = number2;
        number2 = temp;
    }


We make a method that can be accessed by any part of the code that doesnt have to get or set internal fields.
we also reference two integers for both input and output.

then we declare a temp integer;
then we assign the temp integer to number 1
then we make number1 equal to number2
then we make number 2 equal to temp which is number 1's original value
this code just swaps the values of number 1 and 2.

or

this piece of code swaps the value of number 1 and 2 using a temp value to help.


#### Q2:
    Complete the table below to show what each variable holds, the user enters the numbers 5,6,7,8,9


    int evens = 0
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLne("Please Enter a number");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (numbers[i] % 2 == 0)
        {
            evens = evens + 1;
        }
    }
    Console.WriteLine(evens);

Numbers[]|i|Evens|Output|
-----|-----|-----|-----|
5|0|0|0|
6|1|1|0|
7|2|1|0|
8|3|2|0|
9|4|2|0|
||5||2|


#### Q3:
Write A program that lets the user enter exactly 100 numbers, total up these numbers displaying the final total to the screen and the average of the 100 numbers.


    int temp = 0;
    int number = 0;
    int i;
    
    Console.WriteLine("Please Enter 100 Numbers");
    for (i = 0; i < 100; i++)
    {
        temp = Convert.ToInt32(Console.ReadLine());
        number = number + temp;
    }
    Console.WriteLine($"The Total Value Is {number});
    Console.WriteLine($"The Average Is {(number/i)});
