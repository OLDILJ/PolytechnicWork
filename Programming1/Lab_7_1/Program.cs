var team1 = 0;
var team1score = 0;
var team2 = 0;
var team2score = 0;
Random rand = new Random();
var amountofturns = 4;
for (int i = amountofturns; i >= 0; i--)
{
    Console.WriteLine(i);
    team1 = rand.Next(0,8);
    team2 = rand.Next(0,8);
    switch(team1)
    {
        case 7:
            team1score += 7;
            Console.WriteLine("TRY + COVERTED");
            break;
        case 5:
            team1score += 5;
            Console.WriteLine("TRY");
            break;
        case 3:
            team1score += 3;
            Console.WriteLine("KICK");
            break;
        default:
            team1 = 0;
            Console.WriteLine("LOST BALL");
            break;
    }
    Console.WriteLine("SWAP TEAMS");
    switch(team2)
    {
    case 7:
        team2score += 7;
        Console.WriteLine("TRY + COVERTED");
        break;
    case 5:
        team2score += 5;
        Console.WriteLine("TRY");
        break;
    case 3:
        team2score += 3;
        Console.WriteLine("KICK");
        break;
    default:
        team2 = 0;
        Console.WriteLine("LOST BALL");
        break;
    }
    Console.WriteLine("SWAP TEAMS");
}
Console.WriteLine("FINISH");
Console.WriteLine($"TEAM 1 SCORED {team1score}");
Console.WriteLine($"TEAM 2 SCORED {team2score}");
if (team1score > team2score)
{
    Console.WriteLine($"TEAM 1 WON BY {team1score - team2score}");
}
if (team2score > team1score)
{
    Console.WriteLine($"TEAM 2 WON BY {team2score - team1score}");
}
if (team1score == team2score)
{
    Console.WriteLine($"TIE");

}