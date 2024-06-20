// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome To Logan's Logic Gate Simulator!");



// 0 = off
// 1 = on
int a = 1; // and gate
int b = 1; // and gate
int c = 0; // exclusive or gate
int d = 0; // and gate result
int result = 0; // exclusive gate result
string ExitString = "";
while (ExitString != "EXIT")
{
    Console.WriteLine("Please Enter The Integer Values For A, B and C");
    Console.WriteLine("1 = ON and 0 = OFF");
    Console.WriteLine("Integer A: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Integer B: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Integer C: ");
    c = Convert.ToInt32(Console.ReadLine());
    AndGate(a,b);
    Console.WriteLine(d);
    ExclusiveOr(c,d);

    Console.WriteLine($"The Final Result was {result}");
    Console.WriteLine("Please Enter The String EXIT To Exit");
    ExitString = Console.ReadLine();
    //Console.WriteLine(ExitString);
}
Console.WriteLine("Thank You For Using This Logic Gate Simulator");

// only true when both a And B are on
int AndGate (int a, int b)
{
    if (a == b)
    {
        Console.WriteLine("AndGate Step 1 pass");
        if (a == 1)
        {
            Console.WriteLine("AndGate Step 2 Pass");
            d = 1;
        }
    }
    else
    {
        d = 0;
        Console.WriteLine("AndGate Step 1 Fail");
    }
    return d;
}

// only true when either C or D are on not both
// e.g. c = on d = off result = on
// c = off d = on result = on
// c = on d = on result = off
int ExclusiveOr (int d, int c)
{
    if (d != c)
    {
        Console.WriteLine("ExclusiveOr Step 1 Pass");
        if (d == 1)
        {
            Console.WriteLine("ExclusiveOr Step 2.1 Pass");
            result = 1;
        }
        if (c == 1)
        {
            Console.WriteLine("ExclusiveOr Step 2.2 Pass");
            result = 1;
        }
    }

    return result;
}