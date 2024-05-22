// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int AsciCode = 0;
int AsciConvertedUp;
int AsciConvertedDown;
int AsciConverted;
char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
string UserChoice;
string UserString;
int FirstInt;
int SecondInt;
int ThirdInt;
int FourthInt;
double FirstDouble;
double SecondDouble;
double ThirdDouble;
double FourthDouble;
UserString = Console.ReadLine();
UserString = UserString.ToUpper();
char[] UserChar = UserString.ToCharArray();
int FirstInverse = 0;
int DummyNumber1;
int DummyNumber2;
/*for (int i = 0; i < UserChar.Length; i++)
        {
            AsciCode = (int)UserChar[i];
            AsciConverted = (AsciCode);
            char AsciChar = (char) AsciConverted;
            //Console.Write(AsciChar);
            Console.Write(AsciConverted);
        }
*/
Console.WriteLine("Please Give The First Int");
FirstDouble = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Give The Second Int");
SecondDouble = Convert.ToDouble(Console.ReadLine());

for (int o = 0; o < 26; o++)
{
    if (((FirstDouble*o) % 26) == 1)
    {
        Console.WriteLine($"InverseFound{o}");
        FirstInverse = o;
        break;
    }
    Console.Write($"Pass{o} ");
}
for (int i = 0; i < UserChar.Length; i++)
{
    AsciCode = (int)UserChar[i];
    Console.Write($" (Original AsciValue {AsciCode}) ");
    Console.WriteLine($" (Double {FirstDouble})");
    AsciConverted = Convert.ToInt32(((FirstInverse)*((AsciCode - 65) - SecondDouble))%26);
    Console.Write($" (Decoded {AsciConverted}) ");
    AsciConverted = (AsciConverted + 65);
    Console.Write($" (End AsciValue {AsciConverted}) ");
    char AsciChar = (char) (AsciConverted);
    //Console.Write(AsciChar);
    
}