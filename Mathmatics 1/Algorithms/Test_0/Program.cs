// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// step 1 ask user for a number
// step 2 check if its a valid int
// step 3 loop until i = number
// step 3.1 check if i is divisible by 3
// step 3.1.1 if true return fizz
// step 3.2 check if i is divisible by 5
// step 3.2.1 if true return buzz
// step 3.3 check if i is divisible by 3 AND 5
// step 3.3.1 if true return FizzBuzz
// step 3.4 return i if no check is met
// step 4 return number of fizz, buzz, and fizzbuzz.

int UserInt = 0;
string UserInput = "";
int FizzCount = 0;
int BuzzCount = 0;
int FizzBuzzCount = 0;
int NothingCount = 0;
string[] IntCheck = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "0"];
Start();
void Start()
{
    Console.WriteLine("Please Enter A Number");
    UserInput = Console.ReadLine();
    /*bool b = IntCheck.Any(UserInput.Contains);*/
    bool isNumeric = int.TryParse(UserInput, out int _);
    if (isNumeric == false)
    {
        Start();
    }
    else
    {
        MainProgram();
    }
}




void MainProgram()
{
    UserInt = Convert.ToInt32(UserInput);
    for (int i = 1; i <= UserInt; i++)
    {
        //Console.WriteLine("TEST");
        int IntCalc = i;
        bool IntCalcFizz = IntCalc % 3 == 0;
        bool IntCalcBuzz = IntCalc % 5 == 0;
        if ((IntCalcFizz) && (IntCalcBuzz))
        {
            Console.WriteLine("FizzBuzz");
            FizzBuzzCount++;
        }
        else if (IntCalcFizz)
        {
            Console.WriteLine("Fizz");
            FizzCount++;
        }
        else if (IntCalcBuzz)
        {
            Console.WriteLine("Buzz");
            BuzzCount++;
        }
        else
        {
            Console.WriteLine(IntCalc);
            NothingCount++;
        }
        /*switch(IntCalc)
        {
            case ((IntCalc % 3) = 0):
                Console.WriteLine("Fizz");
                break;
            case (IntCalc % 5 = 0):
                Console.WriteLine("Buzz");
                break;
            case ((IntCalc % 5 = 0) and (IntCalc % 3 = 0)):
                Console.WriteLine("FizzBuzz");
                break;
            case default:
                Console.WriteLine(i);
                break;

        }*/
        

            
    }
    Console.WriteLine($"There were {FizzBuzzCount} FizzBuzz");
    Console.WriteLine($"{FizzCount} Fizz");
    Console.WriteLine($"{BuzzCount} Buzz");
    Console.WriteLine($"and {NothingCount} That Were Neither");
}