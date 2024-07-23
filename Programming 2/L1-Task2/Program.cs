namespace L1_Task2;

class Program
{
    static void Main(string[] args)
    {
        int num;
        string FizzBuzzString;

        Console.WriteLine("Hello, World!");
        num = Convert.ToInt32(Console.ReadLine());
        FizzBuzzString = FizzBuzz(num);
        
        string[] FizzBuzzChecker = FizzBuzzString.Split(' ');
        
        foreach (var checker in FizzBuzzChecker)
        {
            Console.WriteLine(checker);
        }
        
        
    }
    static string FizzBuzz(int num)
    {
        string FizzBuzzString = "";
        //Console.WriteLine(num);
        //int numI = num;
        for (int numI = num; numI <= num+15; numI+=2)
        {
            int IniVal = numI;
            Console.WriteLine(numI);
            bool FizzCheck = IniVal % 3 == 0;
            bool BuzzCheck = IniVal % 5 == 0;
            Console.WriteLine(FizzCheck);
            Console.WriteLine(BuzzCheck);
            if (FizzCheck && BuzzCheck)
            {
                FizzBuzzString += "FizzBuzz ";
            }
            else if (FizzCheck)
            {
                FizzBuzzString += "Fizz ";
            }
            else if (BuzzCheck)
            {
                FizzBuzzString += "Buzz ";
            }
            
            else
            {
                Console.WriteLine("Nothing");
            }   
        }
        //Console.WriteLine(FizzBuzzString);
        return FizzBuzzString;
    }
}
