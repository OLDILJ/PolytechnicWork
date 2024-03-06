// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string temp;
bool invalidOperator = false;
double number1, number2, answer = 0;
Console.WriteLine("enter a number");
temp = Console.ReadLine();
number1 = Convert.ToDouble(temp);
Console.WriteLine("Enter another number");
temp = Console.ReadLine();
number2 = Convert.ToDouble(temp);
Console.WriteLine("Select an operator: +; -; *; /");
Console.Write("Please enter your selection");
string myOperator = Console.ReadLine();
//check which operator is selected and do the math equation for it.
switch (myOperator)
{
    case "*":
        answer = number1 * number2;
        break;
    case "+":
        answer = number1 + number2;
        break;
    case "-":
        answer = number1 - number2;
        break;
    case "/":
        answer = number1 / number2;
        break;
    default:
        invalidOperator = true;
        break;
}

if (invalidOperator == true)
{
    Console.WriteLine("You have not selected a valid operator");
}
else
{
    Console.WriteLine($"{number1} {myOperator} {number2} = {answer:F}");
}
Console.ReadLine();
