using System;
using System.IO;
using System.Text;


int age = 0;
string confirmation;
int dayslived;
int hourslived;
double timeleft;
string all_data;

Console.WriteLine("Good Day. Welcome to Logans Age calculator. How old are you?");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Just to confirm you are {age} years old correct? Type y to confirm");
confirmation = Console.ReadLine();
Console.ReadLine();
if (confirmation.Equals("y"))
{
    Console.WriteLine("Thank You");
    Convert.ToInt32(dayslived = age * 365);
    Console.WriteLine($"You have lived for {dayslived} Days old.");
    hourslived = Convert.ToInt32(dayslived * 24);
    Console.WriteLine($"{hourslived} Hours old.");
    Convert.ToDouble(timeleft = 82.06 - age);
    Console.WriteLine($"You also have approximately {timeleft} Years left");
    all_data = Convert.ToString($"You are {age} Years Old, {dayslived} Days Old, {hourslived} Hours Old, and have {timeleft} Years left to live");
    Console.WriteLine("Thank you for participating in this calculator your data has been printed out for future reference");
    Console.WriteLine("Exiting program press anything to leave");
    Console.ReadLine();
    //creating a stringbuilder
    StringBuilder sb = new StringBuilder();
    //passing the stringbuilder instance into stringWriter
    StringWriter writer = new StringWriter(sb);
    //writing data to stringwriter
    writer.WriteLine(all_data);
    writer.Flush();
    //FileWriter fw = new FileWriter("file.txt");
    //fw.write(writer.toString());
    //fw.close();
    //System.IO.File.WriteAllText("*", all_data);
    StreamWriter sw = new StreamWriter("test.txt");
   // sw.WriteLine(all_data);
    // Console.WriteLine(sw);
    //Creates file then writes each line one by one until it reaches the bottom
    StringReader reader = new StringReader(sb.ToString());
    while (reader.Peek() > 0)
            {
                sw.WriteLine(reader.ReadLine());
            }
        sw.Close();

 //   sw.Write(writer.WriteLine + ",");
}
else
{
    Console.WriteLine("Exiting program press anything to leave");
    Console.ReadLine();
}