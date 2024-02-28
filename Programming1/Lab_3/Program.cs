// See https://aka.ms/new-console-template for more information
double days;
double hours;
double years;
double minutes;
double months;
string confirmation;

Console.WriteLine("Hello, Welcome to Logans Hour Calculator!");
Console.WriteLine("What do you want to do today?");
Console.WriteLine("1. Convert Hours to Days");
Console.WriteLine("2. Convert Hours to Months");
Console.WriteLine("3. Convert Hours to Years");
Console.WriteLine("4. Convert hours to Minutes");

confirmation = Console.ReadLine();
Console.ReadLine();
if (confirmation.Equals("1"))
{
    Console.WriteLine("You have selected the Hours to Days option.");
    Console.WriteLine("Enter Hours");
    hours = Convert.ToInt32(Console.ReadLine());
    days = (hours / 24);
    Console.WriteLine("There are " + days + " days in " + hours +" hours");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else if (confirmation.Equals("2"))
{
    Console.WriteLine("You have selected the Hours to Months option.");
    Console.WriteLine("Enter Hours");
    hours = Convert.ToInt32(Console.ReadLine());
    months = (hours / 24 / 30);
    Console.WriteLine("There are " + months + " months in " + hours +" hours");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else if (confirmation.Equals("3"))
{
    Console.WriteLine("You have selected the Hours to Years option.");
    Console.WriteLine("Enter Hours");
    hours = Convert.ToInt32(Console.ReadLine());
    years = (hours / 24 / 365);
    Console.WriteLine("There are " + years + " years in " + hours +" hours");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else if (confirmation.Equals("4"))
{
    Console.WriteLine("You have selected the Hours to Minutes option.");
    Console.WriteLine("Enter Hours");
    hours = Convert.ToInt32(Console.ReadLine());
    minutes = (hours * 60);
    Console.WriteLine("There are " + minutes + " minutes in " + hours +" hours");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
    }
else 
{
    Console.WriteLine("Unknown Answer. Aborting Program.");
    Console.WriteLine("Press any key to exit");
    Console.ReadLine();
}