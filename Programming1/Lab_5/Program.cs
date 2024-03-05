Random rand = new Random();
string confirmation;
int coinflip = rand.Next(1,3);
Console.WriteLine("Heads or Tails?");
Console.WriteLine("1. Head");
Console.WriteLine("2. Tails");
confirmation = Console.ReadLine();
if (confirmation.Equals("1"))
    {
        Console.WriteLine("You Have Picked Heads");
        if (coinflip == 1)
            {
            Console.WriteLine("You Win!");
            //Console.WriteLine(coinflip); //check flip result
            Console.ReadLine();
            }   
        else 
            {
            Console.WriteLine("You Lose");
            //Console.WriteLine(coinflip); //check flip result
            Console.ReadLine();
            }   
    }
if (confirmation.Equals("2"))
{
    Console.WriteLine("You Have Picked Tails");
    if (coinflip == 2)
        {
            Console.WriteLine("You Win!");
            //Console.WriteLine(coinflip); //check flip result
            Console.ReadLine();
        }
    else 
        {
            Console.WriteLine("You Lose");
            //Console.WriteLine(coinflip); //check flip result
            Console.ReadLine();
        }   
}