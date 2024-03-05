// See https://aka.ms/new-console-template for more information
Random rand = new Random();
int team_1 = rand.Next(10);
int team_2 = rand.Next(10);
Console.WriteLine($"team 1 scored {team_1}, team 2 scored {team_2}");
Console.WriteLine("Welcome to Logan Soccer game");
Console.WriteLine($"Its half time the score is {rand.Next(0,team_1)} | {rand.Next(0,team_2)}");
Console.ReadLine();
if (team_2 > team_1)
{
    Console.WriteLine("Your team won!");
    Console.WriteLine($"Your team won by {team_2 - team_1} points!");
    Console.WriteLine($"The final score was {team_1} | {team_2}");
}
if (team_1 > team_2)
{
    Console.WriteLine("Your team lost :(");
    Console.WriteLine($"Your team lost by {team_1 - team_2} points!");
    Console.WriteLine($"The final score was {team_1} | {team_2}");
}
if (team_1 == team_2)
{
    Console.WriteLine("Your team drew :|");
    Console.WriteLine($"The final score was {team_1} | {team_2}");
}
Console.ReadLine();