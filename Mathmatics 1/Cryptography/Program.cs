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
/*
for (int i = 0; i < alpha.Length; i++)
{
    AsciCode = (int)alpha[i];
    AsciConvertedUp = AsciCode + 3;
    AsciConvertedDown = AsciCode - 3;
    char AsciChar = (char) AsciCode;
    char AsciConvertedUpChar = (char) AsciConvertedUp;
    char AsciConvertedDownChar = (char) AsciConvertedDown;

    Console.WriteLine(AsciChar);
    Console.WriteLine(AsciConvertedUpChar);
    Console.WriteLine(AsciConvertedDownChar);
}
*/
Console.WriteLine("Thank You For Using Cipher Decipherer");
Console.WriteLine("Please Enter The String you want Ciphered");
UserString = Console.ReadLine();
UserString = UserString.ToUpper();
char[] UserChar = UserString.ToCharArray();
Console.WriteLine("Now Select What Cipher You Want To Apply");
Console.WriteLine("1. Caeser (+3)");
Console.WriteLine("2. Undo Caeser (-3)");
Console.WriteLine("3. Affine (aP + b)");
UserChoice = Console.ReadLine();
switch (UserChoice)
{
    case "1":

        for (int i = 0; i < UserChar.Length; i++)
        {
            // Step 1: use i as a buffer to go through char array
            // Step 2: convert to ascicode
            // Step 3: change ascicode value by caeser
            // Step 4: Write to screen NOT WRITELINE
            AsciCode = (int)UserChar[i];
            AsciConverted = (AsciCode + 3);
            char AsciChar = (char) AsciConverted;
            Console.Write(AsciChar);
        }
        break;
    case "2":
            // Step 1: use i as a buffer to go through char array
            // Step 2: convert to ascicode
            // Step 3: change ascicode value by caeser
            // Step 4: Write to screen NOT WRITELINE
        for (int i = 0; i < UserChar.Length; i++)
        {
            AsciCode = (int)UserChar[i];
            AsciConverted = (AsciCode - 3);
            char AsciChar = (char) AsciConverted;
            Console.Write(AsciChar);
        }
        break;
    case "3":
        Console.WriteLine("Please Give The First Int");
        FirstInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Give The Second Int");
        SecondInt = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < UserChar.Length; i++)
        {
            AsciCode = (int)UserChar[i];
            AsciConverted = (((FirstInt * (AsciCode - 65)) + SecondInt) % 26);
            char AsciChar = (char) (AsciConverted + 65);
            Console.Write(AsciChar);
            //Console.Write(AsciConverted);
        }
        break;
    case "4":
        Console.WriteLine("Please Give The First Int");
        FirstInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Give The Second Int");
        SecondInt = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < UserChar.Length; i++)
        {
            AsciCode = (int)UserChar[i];
            AsciConverted = (-FirstInt*((AsciCode - 65) - SecondInt) % 26);
            char AsciChar = (char) (AsciConverted + 65);
            //Console.Write(AsciChar);
            Console.Write(AsciConverted);
        }
        break;

        
        
    
}
