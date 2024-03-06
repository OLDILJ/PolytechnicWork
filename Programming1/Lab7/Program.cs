string test;
Random rand = new Random();
int CpuChoice;
int PlayerChoice = 0;
string PlayerWin = "test";
string PlayerSelection = "test";
bool invalidResponse = false;
Console.WriteLine("Welcome to RPS");
Console.WriteLine("Select your choice");
Console.WriteLine("1. ROCK");
Console.WriteLine("2. PAPER");
Console.WriteLine("3. SCISSORS");
PlayerSelection = Console.ReadLine();
CpuChoice = rand.Next(1,4);
string CpuWin = "test";
switch(CpuChoice)
{
    case 1:
        CpuWin = "Rock";
        break;
    case 2:
        CpuWin = "Paper";
        break;
    case 3:
        CpuWin = "Scissors";
        break;
}
switch(PlayerSelection)
{
    case "ROCK" or "1":
        PlayerChoice = 1;
        PlayerWin = "Rock";
        break;
    case "PAPER" or "2":
        PlayerChoice = 2;
        PlayerWin = "Paper";
        break;
    case "SCISSORS" or "3":
        PlayerChoice = 3;
        PlayerWin = "Scissors";
        break;
}

Console.WriteLine($"PLAYER USES {PlayerWin} vs CPU USES {CpuWin}");

if (PlayerChoice == CpuChoice)
{
    Console.WriteLine("DRAW");
} 
else if ((PlayerChoice == 1) && (CpuChoice == 3) || ((PlayerChoice == 2) && (CpuChoice == 1)) || ((PlayerChoice == 3) && (CpuChoice == 2)))
{
    Console.WriteLine("YOU WIN");
}
else
{
    Console.WriteLine("YOU LOSE");
}
