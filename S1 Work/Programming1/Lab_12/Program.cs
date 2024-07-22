// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random rand = new Random();
int[] randomnumbers = new int[10];
for (int i = 0; i < randomnumbers.Length; i++)
{
    randomnumbers[i] = rand.Next(1,10);
}
for (int d = 0; d < randomnumbers.Length; d++)
{
    Console.WriteLine(randomnumbers[d]);
}