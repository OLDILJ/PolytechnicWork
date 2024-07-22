string test;
int CpuChoice;
int PlayerChoice;
bool invalidResponse = false;
Console.WriteLine("Welcome to RPS");
Console.WriteLine("Select your choice");
Console.WriteLine("1. ROCK");
Console.WriteLine("2. PAPER");
Console.WriteLine("3. SCISSORS");
PlayerSelection = Console.ReadLine();
CpuChoice = rand.Next(3);
switch(PlayerSelection)
{
    case "ROCK" or "1":
        PlayerChoice = 1;
        break;
    case "PAPER" or "2":
        PlayerChoice = 2;
        break;
    case "SCISSORS" or "3":
        PlayerChoice = 3;
        break;
}
Console.WriteLine($"{PlayerChoice} {CpuChoice}");