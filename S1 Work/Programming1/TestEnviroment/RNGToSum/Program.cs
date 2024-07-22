// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int IntSize = 5;
int[] nums;
IntSize = 5;
int Total = 100;
//int[] RollTotal;
int RollTotal = 0;
Random rand = new Random();

RNGToSum(IntSize, Total);
//RollTotal = new int[IntSize];
/*
for (int i = 0; i != IntSize; i++)
{
    RollTotal[i] = nums[i];
    Console.WriteLine($"Number in slot #{i} {nums[i]}");
}
for (int i = 0; i != IntSize; i++)
{
    int TotalValue = 0;
    TotalValue = RollTotal[i] + TotalValue;
    Console.WriteLine($"Rolling Total Checker #{i} {TotalValue}");
    Console.WriteLine(RollTotal[i]);
}
*/
for (int i = 0; i != IntSize; i++)
{
    RollTotal += nums[i];
    Console.WriteLine($"{nums[i]}");
    Console.WriteLine(RollTotal);
}



//Create an int array
//Define the Maximum value (100 in this case) for rand - desired amount - crrent sum of array each loop
//generate x amount of times
//Check if the sum of all nums is 100
// Return Nums

int[] RNGToSum(int IntSize, int Total)
{
    {
        nums = new int[IntSize];
        for (int i = 0; i < IntSize; i++)
        {
            int sum = nums.Sum();
            nums[i] = rand.Next(0,(Total - sum));
            Console.WriteLine($"number #{i} generated");
        }
        int sum1 = nums.Sum();
        nums[IntSize-1] = (Total - sum1) + nums[IntSize-1];
    }
    return nums;

}
