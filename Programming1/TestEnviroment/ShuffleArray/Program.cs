// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] test = {10,2,4,1,3,2,1,2,3,4,1};

//test = new int[10];
Random.Shared.Shuffle(test);
Console.WriteLine(test[1]);