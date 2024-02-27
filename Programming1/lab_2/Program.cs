int age;
string confirmation;
int dayslived;
int hourslived;
double timeleft;
string all_data;

Console.WriteLine("Good Day. Welcome to Logans Age calculator. How old are you?");
age = Console.Read();
Console.WriteLine("Just to confirm you are " + age);
Console.Write(" years old correct? Type y to confirm");
confirmation = Console.ReadLine();
if (confirmation.Equals("y"))
{
    Console.WriteLine("Thank You");
    dayslived = age * 365;
    Console.WriteLine("You have lived for " + dayslived);
    hourslived = dayslived * 24;
    Console.Write(" Days old and " + hourslived);
    Console.Write(" Hours old");
    timeleft = 82.06 - age;
    Console.WriteLine("You also have approximately" + timeleft);
    Console.Write(" years left");
    all_data = ("You are " + age + " Old " + dayslived + " Days Old " + hourslived + " Hours Old and have " + timeleft + " Years left to live");
    Console.WriteLine("Thank you for participating in this calculator your data has been printed out for future reference");
    Console.WriteLine("Exiting program press anything to leave");
    System.IO.File.WriteAllText("*", all_data);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Exiting program press anything to leave");
    Console.ReadLine();
}