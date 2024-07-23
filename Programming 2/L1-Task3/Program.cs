namespace L1_Task3;

class Program
{
    static void Main(string[] args)
    {
        //step 1 create array of ints called num
        //step 2 iterate and check if theres odd numbers in num
        //step 3 if it is display it
        //step 4 sort array from lowest to highest then display it.
        Console.WriteLine("Hello, World!");
        int[] oddnum = new int[6];
        int[] num = {21, 19, 68, 55, 42, 12};
        Console.WriteLine("Num Array Loaded");
        int i = 0;
        foreach (var number in num)
        {
            if (number % 2 == 1)
            {
                oddnum[i] = number;
                Console.WriteLine(number);
            }
            else
            {

            }
            i++;
        }
        Console.WriteLine("---");
        Array.Sort(oddnum);
        Array.Reverse(oddnum);
        foreach (var _ in oddnum)
        {
            Console.WriteLine(_);
        }
        Array.Sort(num);
        Console.WriteLine("---");
        foreach (var _ in num)
        {
            Console.WriteLine(_);
        }
        
    }
}
