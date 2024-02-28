// See https://aka.ms/new-console-template for more information
const double aud = 0.8085;
const double usd = 0.8272;
const double pound = 0.5457;
const double yen = 76.23;
const double euro = 0.6297;
string confirmation;
double nzd = 0;
double result = 0;
Console.WriteLine("Welcome to Logans NZD Exchange Rate program");
Console.WriteLine("What do you want to do today?");
Console.WriteLine("1. Convert to AUD");
Console.WriteLine("2. Convert to USD");
Console.WriteLine("3. Convert to POUND");
Console.WriteLine("4. Convert to YEN");
Console.WriteLine("5. Convert to EURO");
confirmation = Console.ReadLine();
Console.ReadLine();
if (confirmation.Equals("1"))
{
    Console.WriteLine("You have selected the Convert to AUD option.");
    Console.WriteLine("Enter NZD");
    nzd = Convert.ToInt32(Console.ReadLine());
    result = (nzd * aud);
    Console.WriteLine(nzd + "NZD converts to " + result + " AUD");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else if (confirmation.Equals("2"))
{
    Console.WriteLine("You have selected the Convert to USD option.");
    Console.WriteLine("Enter NZD");
    nzd = Convert.ToInt32(Console.ReadLine());
    result = (nzd * usd);
    Console.WriteLine(nzd + "NZD converts to " + result + " USD");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else if (confirmation.Equals("3"))
{
    Console.WriteLine("You have selected the Convert to POUND option.");
    Console.WriteLine("Enter NZD");
    nzd = Convert.ToInt32(Console.ReadLine());
    result = (nzd * pound);
    Console.WriteLine(nzd + "NZD converts to " + result + " Pounds");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else if (confirmation.Equals("4"))
{
    Console.WriteLine("You have selected the Convert to YEN option.");
    Console.WriteLine("Enter NZD");
    nzd = Convert.ToInt32(Console.ReadLine());
    result = (nzd * yen);
    Console.WriteLine(nzd + "NZD converts to " + result + " Yen");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else if (confirmation.Equals("5"))
{
    Console.WriteLine("You have selected the Convert to EURO option.");
    Console.WriteLine("Enter NZD");
    nzd = Convert.ToInt32(Console.ReadLine());
    result = (nzd * euro);
    Console.WriteLine(nzd + "NZD converts to " + result + " Euro");
    Console.WriteLine("Press the enter key to leave");
    Console.ReadLine();
}
else 
{
    Console.WriteLine("Unknown Answer. Aborting Program.");
    Console.WriteLine("Press any key to exit");
    Console.ReadLine();
}