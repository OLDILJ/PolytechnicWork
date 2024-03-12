Random rand = new Random();
int playernumber = 0;
int cpucurrent = 0;
int cpumax =  100;
int cpumin = 1;
int guessesneeded = 0;
Console.WriteLine("Robot Rob Robot Counter");
Console.WriteLine("Robot Rob: Hello Give Me A Number Between 1 and 100");
playernumber = Convert.ToInt32(Console.ReadLine());
//    do
//    {
//        Console.WriteLine("Unknown Number Read Please Try Again");
//    } while (playernumber != int);
Console.WriteLine("Robot Rob: Thanks!");
cpucurrent = rand.Next(cpumin,cpumax);
Console.WriteLine($"Robot Rob: I Think The Number Is {cpucurrent}");
do
{
    guessesneeded += 1;
    Console.WriteLine($"Robot Rob: Oh I Got It Wrong :[ ");
    Console.WriteLine($"Robot Rob: Was It Higher Or Lower");
    Thread.Sleep(rand.Next(200,500));
    if (cpucurrent > playernumber)
    {
        Console.WriteLine($"Robot Rob: So The Number Is Smaller");
        Thread.Sleep(rand.Next(200,500));
        cpumax = cpucurrent;
    }
    if (cpucurrent < playernumber)
    {
        Console.WriteLine($"Robot Rob: So The Number Is Bigger");
        Thread.Sleep(rand.Next(200,500));
        cpumin = cpucurrent + 1;
    }
    cpucurrent = rand.Next(cpumin,cpumax);
    Thread.Sleep(rand.Next(200,500));
    Console.WriteLine($"Robot Rob: I Think The Number Is {cpucurrent}");

    
} while(cpucurrent != playernumber);
Console.WriteLine($"Robot Rob: I Got It Right!");
Console.WriteLine($"Robot Rob: The Number Was {cpucurrent}");
Console.WriteLine($"Robot Rob: It Took Me {guessesneeded} Tries To Get It Right");