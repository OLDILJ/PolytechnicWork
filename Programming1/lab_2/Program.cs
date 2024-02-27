int age = 0;
string confirmation;
int dayslived;
int hourslived;
double timeleft;
string all_data;

Console.WriteLine("Good Day. Welcome to Logans Age calculator. How old are you?");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Just to confirm you are " + age + " years old correct? Type y to confirm");
confirmation = Console.ReadLine();
Console.ReadLine();
if (confirmation.Equals("y"))
{
    Console.WriteLine("Thank You");
    Convert.ToInt32(dayslived = age * 365);
    Console.WriteLine("You have lived for " + dayslived + " Days old.");
    hourslived = Convert.ToInt32(dayslived * 24);
    Console.WriteLine(hourslived + " Hours old. ");
    Convert.ToDouble(timeleft = 82.06 - age);
    Console.WriteLine("You also have approximately " + timeleft + " Years left");
    all_data = ("You are " + age + " Old " + dayslived + " Days Old " + hourslived + " Hours Old and have " + timeleft + " Years left to live");
    Console.WriteLine("Thank you for participating in this calculator your data has been printed out for future reference");
    Console.WriteLine("Exiting program press anything to leave");
    Console.ReadLine();

    //System.IO.File.WriteAllText("*", all_data);
}
else
{
    Console.WriteLine("Exiting program press anything to leave");
    Console.ReadLine();
}