Random rand = new Random();
bool balls_team1 = true;
int team1score = 0;
int team2score = 0;
int team1members = rand.Next(4,7);
int team2members = rand.Next(1,10);
int team1skill = rand.Next(3,7);
int team2skill = rand.Next(1,6);
int team1strength = ((team1members * team1skill)/2);
int team2strength = ((team2members * team2skill)/2);
int time_left_in_game = 60;
int teamscoring = 0;
int attackingteam = 0;
int defendingteam = 0;
Console.WriteLine("WELCOME TO THE ANNUAL BALL GAME TOURNAMENT!");
Console.WriteLine("IT'S LOOKING TO BE A FIERCE GAME OUT THERE");
Console.WriteLine("BOTH TEAMS ARE BRINGING THEIR A GAME!");
Console.WriteLine($"ON THE HOME TEAM WE HAVE THE FLAWLESS");
Console.WriteLine($"WITH {team1members} PLAYERS AT RANK {team1skill}");
Console.WriteLine("THE FLAWLESS HAVE ALWAYS BEEN A VERY CONSISTENT TEAM!");
Console.WriteLine("AND ON THE AWAY TEAM WE HAVE THE RAIDERS!");
Console.WriteLine($"WITH {team2members} PLAYERS AT RANK {team2skill}");
Console.WriteLine("THE RAIDERS ARE A STRANGE BUNCH, SOME GAMES THEY ARE AS GOOD AS CHILDREN OTHER TIMES THEY ARE THE BEST AROUND!");

/*
step 1: team 1 starts with the ball
step 2: team 1 has to attack team 2 has to defend
step 3: random num between 0-10 to show if they succeeded 
step 3.1: influenced by each teams skill
step 4: once clock hits 30 swap who has the ball
*/


for (int i = time_left_in_game; i >= 0; i--)
{
    if (balls_team1);
    {
        
        attackingteam = team1strength;
        defendingteam = team2strength;
    }
    if (!balls_team1);
    {
        
        attackingteam = team2strength;
        defendingteam = team1strength;
    }
    teamscoring = (rand.Next(1,8) + attackingteam);
    if ((teamscoring >= (rand.Next(1,8) %+ defendingteam)) && balls_team1)
    {
        team1score += 1;
        Console.WriteLine($"TEAM 1 SCORES!");
    }
    if ((teamscoring >= defendingteam) && !balls_team1)
    {
        team2score += 1;
        Console.WriteLine($"TEAM 2 SCORES!");
    }
    if (time_left_in_game > 30);
    {
        balls_team1 = !balls_team1;
    }
}
Console.WriteLine($"TEAM 1: {team1score}");
Console.WriteLine($"TEAM 2: {team2score}");
 

















/*
int i;
Console.WriteLine("Counting up");
for (i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Counting Down");
for (i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

Console.ReadLine();

Console.WriteLine("for loop with characters");
for (char j = 'a'; j<'g'; j++)
{
    Console.WriteLine(j);
}

Console.ReadLine();

Console.WriteLine("For loop with double");
for (double x=0; x <= 2.5; x=x+0.5)
{
    Console.WriteLine(x);
}
int start = 2;
int max = 4;
for (i = start; i <= max; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("7 times table");
int answer = 0;
for (i = 1; i<=10; i++)
{
    answer = 7*i;
    Console.WriteLine($"7 * {i} = {answer}");
}
*/