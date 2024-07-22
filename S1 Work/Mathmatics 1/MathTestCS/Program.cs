Console.WriteLine("TEST LINE");
ProgramSelecter();


static void ProgramSelecter()
{
Console.WriteLine("Select Your Standard");
Console.WriteLine("1. Checksum Checker");
Console.WriteLine("2. Cryptography Checker");
int ProgramSelect = 0;
ProgramSelect = Convert.ToInt32(Console.ReadLine());
switch(ProgramSelect)
{
    case 1:
        Checksum();
        break;
    case 2:
        Cryptography();
        break;
    default:
        Console.WriteLine("Unknown Input");
        Console.WriteLine("Resetting");
        ProgramSelecter();
        break;
}
}

static void Checksum()
{

string SelectedStandard; 
string prefix;
int UserChecksum = 0;
string InputDigits;
int TrueChecksum = 0;
List<int> intAry = new List<int>();
Console.WriteLine("Select Your Standard");
Console.WriteLine("1. UPC");
Console.WriteLine("2. ISBN");
Console.WriteLine("3. EAN-13");
SelectedStandard = Console.ReadLine();
SelectedStandard.ToLower();
switch(SelectedStandard)
{
    case "1" or "1." or "upc":
        Console.WriteLine("Selected UPC Standard");
        Console.WriteLine("Enter 11 Digits in the Following Format");
        Console.WriteLine(" '1 4 3 2 5 6 4 3 2 5 6' ");
        InputDigits = Console.ReadLine();

        for (int i = 0; i < InputDigits.Length; i++)
        {
            intAry.Add(Convert.ToInt32(InputDigits[i]- '0')/* */);
            //intAry[i] = InputDigits[i] - '0';
            //Console.WriteLine(intAry[i]);
        }
        Console.WriteLine("Now Enter The Checksum Digit");

       /* foreach(var item in intAry)
        {
            Console.WriteLine(item);
        }*/
        

        Console.WriteLine(intAry.Count);
        UserChecksum = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < intAry.Count; i++)
        {
            if (i % 2 == 0)
            {
                sum += 3 * intAry[i];
            }
            else
            {
                sum += intAry[i];
            }
        }
        TrueChecksum = (-sum) % 10;
        if (TrueChecksum < 0)
        {
            TrueChecksum += 10;
        }

        //TrueChecksum = (-1*(3*intAry[0]+intAry[1]+3*intAry[2]+intAry[3]+3*intAry[4]+intAry[5]+3*intAry[6]+intAry[7]+3*intAry[8]+intAry[9]+3*intAry[10])%10);
       /* for (int i = 0; i < intAry.Count; i++)
        {
            Console.WriteLine($"IntAry[{i}] = ");
            Console.WriteLine(intAry[i]);
        }*/
        Console.WriteLine($"The TrueChecksum = {TrueChecksum}");

        break;
    case "2" or "2." or "isbn":
        Console.WriteLine("Selected ISBN");
        Console.WriteLine("Prefix 978 or 979?");
        prefix = Console.ReadLine();
        switch(prefix){
            case "978":
                intAry.Add(9);
                intAry.Add(7);
                intAry.Add(8);
                break;
            case "979":
                intAry.Add(9);
                intAry.Add(7);
                intAry.Add(9);
                break;




        }
        Console.WriteLine("Enter 9 Digits in the Following Format");
        Console.WriteLine(" '1 4 3 2 5 6 4 3 2' ");
        InputDigits = Console.ReadLine();

        for (int i = 0; i < InputDigits.Length; i++)
        {
            intAry.Add(Convert.ToInt32(InputDigits[i]- '0')/* */);
            //intAry[i] = InputDigits[i] - '0';
            //Console.WriteLine(intAry[i]);
        }
        Console.WriteLine("Now Enter The Checksum Digit");

       /* foreach(var item in intAry)
        {
            Console.WriteLine(item);
        }*/
        
        // Step 1. Sum up all digits in even positions
        // Step 2. Sum up all digits in the odd positions
        // Step 3. Multiply even position sum by 3
        // Step 4. combine new EvenSum and oddsum
        // Step 5. mod 10 combined answer
        // Step 6. If its not 0 subtract it from 10
        // Step 7. Finish
        Console.WriteLine(intAry.Count);
        UserChecksum = Convert.ToInt32(Console.ReadLine());
        int sum4 = 0;
        int sum5 = 0;
        for (int i = 0; i < intAry.Count; i++)
        {
            if (i % 2 == 0)
            {
                sum4 += intAry[i];
            }
            else
            {
                sum5 += intAry[i];
            }
        }
        Console.WriteLine(sum4);
        Console.WriteLine(sum5);
        TrueChecksum = ((3*sum5)+(sum4)) % 10;
        
        if (TrueChecksum > 0)
        {
            TrueChecksum = 10 - TrueChecksum;
        }

        //TrueChecksum = (-1*(3*intAry[0]+intAry[1]+3*intAry[2]+intAry[3]+3*intAry[4]+intAry[5]+3*intAry[6]+intAry[7]+3*intAry[8]+intAry[9]+3*intAry[10])%10);
        /*for (int i = 0; i < intAry.Count; i++)
        {
            Console.WriteLine($"IntAry[{i}] = ");
            Console.WriteLine(intAry[i]);
        }*/
        Console.WriteLine($"The TrueChecksum = {TrueChecksum}");

        break;
    case "3" or "3." or "ean13" or "ean" or "ean-13":
        Console.WriteLine("Selected EAN-13");
        Console.WriteLine("Enter 12 Digits in the Following Format");
        Console.WriteLine(" '1 4 3 2 5 6 4 3 2 5 6 1' ");
        InputDigits = Console.ReadLine();

        for (int i = 0; i < InputDigits.Length; i++)
        {
            intAry.Add(Convert.ToInt32(InputDigits[i]- '0')/* */);
            //intAry[i] = InputDigits[i] - '0';
            //Console.WriteLine(intAry[i]);
        }
        Console.WriteLine("Now Enter The Checksum Digit");

       /* foreach(var item in intAry)
        {
            Console.WriteLine(item);
        }*/
        
        // Step 1. Sum up all digits in even positions
        // Step 2. Sum up all digits in the odd positions
        // Step 3. Multiply even position sum by 3
        // Step 4. combine new EvenSum and oddsum
        // Step 5. mod 10 combined answer
        // Step 6. If its not 0 subtract it from 10
        // Step 7. Finish
        Console.WriteLine(intAry.Count);
        UserChecksum = Convert.ToInt32(Console.ReadLine());
        int sum2 = 0;
        int sum3 = 0;
        for (int i = 0; i < intAry.Count; i++)
        {
            if (i % 2 == 0)
            {
                sum2 += intAry[i];
            }
            else
            {
                sum3 += intAry[i];
            }
        }
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);
        TrueChecksum = ((3*sum3)+(sum2)) % 10;
        
        if (TrueChecksum > 0)
        {
            TrueChecksum = 10 - TrueChecksum;
        }

        //TrueChecksum = (-1*(3*intAry[0]+intAry[1]+3*intAry[2]+intAry[3]+3*intAry[4]+intAry[5]+3*intAry[6]+intAry[7]+3*intAry[8]+intAry[9]+3*intAry[10])%10);
        /*for (int i = 0; i < intAry.Count; i++)
        {
            Console.WriteLine($"IntAry[{i}] = ");
            Console.WriteLine(intAry[i]);
        }*/
        Console.WriteLine($"The TrueChecksum = {TrueChecksum}");

        break;
    }

}

static void Cryptography()
{
    int AsciCode = 0;
    int AsciCode2 = 0;
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
    int FirstInverse = 0;
    int SecondInverse = 0;
    int ThirdInverse = 0;
    int FourthInverse = 0;

    int DummyNumber1;
    int DummyNumber2;
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
    Console.WriteLine("4. Undo Affine (aP + b)");
    Console.WriteLine("5. Hill (C1 = (aP1 + bP2)mod26) (C2 = (cP1 + dP2)mod26)");
    Console.WriteLine("6. Undo Hill (C1 = (aP1 + bP2)mod26) (C2 = (cP1 + dP2)mod26)");
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
        //Console.Write($"Pass{o} ");
        }
        for (int i = 0; i < UserChar.Length; i++)
        {
            AsciCode = (int)UserChar[i];
            Console.Write($" (Original AsciValue {AsciCode}) ");
            Console.Write($" (Double {FirstDouble})");
            AsciConverted = Convert.ToInt32(((FirstInverse)*((AsciCode - 65) - SecondDouble))%26);
            if (AsciConverted < 0)
            {
                AsciConverted = -AsciConverted;
            }
            Console.Write($" (Decoded {AsciConverted}) ");
            AsciConverted = (AsciConverted + 65);
            Console.Write($" (End AsciValue {AsciConverted}) ");
            char AsciChar = (char) (AsciConverted);
            Console.WriteLine(AsciChar);
            
        }
            break;
        case "5":
        //Hill Code
        // p1 and p2 and plain text letters for each 4 Letter block
        // c1 and c2 are cipher text letters for each 4 letter block
        // a b c and d are all integers between 0 and 25 (26 in total)
        // encoding matrix is:
        // A = /A   B\
        //     \C   D/
        // c1 = (a*p1 + b*p2)mod26
        // c2 = (c*p1 + d*p2)mod26

            Console.WriteLine("Please Give The First Int");
            FirstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Give The Second Int");
            SecondInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Give The Third Int");
            ThirdInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Give The Fourth Int");
            FourthInt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < UserChar.Length; i += 2)
            {
                AsciCode = (int)UserChar[i];
                if (i < ((UserChar.Length)-1))
                {
                    AsciCode2 = (int)UserChar[i+1];
                }
                else
                    AsciCode2 = 65;
                
                Console.WriteLine($"AsciCode1: {AsciCode} Character{i}");
                Console.WriteLine($"AsciCode1 Converted: {AsciCode-65}");
                Console.WriteLine($"AsciCode2: {AsciCode2}");
                Console.WriteLine($"AsciCode2 Converted: {AsciCode2-65} Character{i+1}");

                AsciConverted = ((FirstInt*(AsciCode - 65)) + (SecondInt*(AsciCode2 - 65)));
                Console.WriteLine($"AsciConverted PreMod: {AsciConverted}");
                AsciConverted = (AsciConverted%26);
                Console.WriteLine($"AsciConverted: {AsciConverted}");

                AsciConvertedUp = ((ThirdInt*(AsciCode - 65)) + (FourthInt*(AsciCode2 - 65)));
                Console.WriteLine($"AsciConvertedup PreMod: {AsciConvertedUp}");
                AsciConvertedUp = (AsciConvertedUp%26);
                Console.WriteLine($"AsciConvertedup: {AsciConverted}");
                char AsciChar = (char) (AsciConverted+65);
                Console.WriteLine(AsciChar);
                char AsciConvertedUpChar = (char) (AsciConvertedUp+65);
                Console.WriteLine(AsciConvertedUpChar);

                //Console.WriteLine(AsciConvertedUp);
                //This is cursed big time

            }
            break;
        
        case "6":
        //Hill Decoder
        // p1 and p2 and plain text letters for each 4 Letter block
        // c1 and c2 are cipher text letters for each 4 letter block
        // a b c and d are all integers between 0 and 25 (26 in total)
        // decoding matrix is:
        // det A = /D   -B\
        //         \-C   A/
        //
            Console.WriteLine("Please Give The First Int");
            FirstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Give The Second Int");
            SecondInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Give The Third Int");
            ThirdInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Give The Fourth Int");
            FourthInt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < UserChar.Length; i += 2)
            {
                AsciCode = (int)UserChar[i];
                if (i <= ((UserChar.Length)-1))
                {
                    AsciCode2 = (int)UserChar[i+1];
                }
                else
                    AsciCode2 = 65;
                
                int det = ((FirstInt*FourthInt) - (ThirdInt*SecondInt));
                det = (det+26);
                Console.WriteLine(det);
                
                for (int o = 0; o < 26; o++)
                {
                    if (((det*o) % 26) == 1)
                    {
                        //Console.WriteLine($"InverseFound{o}");
                        FirstInverse = o;
                        break;
                    }
                    //find the inverse and multiply the matrix by it
                    // MOD 26 LAST
                Console.Write($"Pass{o} ");
                }


                
                //Console.WriteLine($"AsciCode1: {AsciCode} Character{i}");
                //Console.WriteLine($"AsciCode1 Converted: {AsciCode-65}");
                //Console.WriteLine($"AsciCode2: {AsciCode2}");
                //Console.WriteLine($"AsciCode2 Converted: {AsciCode2-65} Character{i+1}");

                AsciConverted = ((FourthInt*(AsciCode - 65)) + (-SecondInt*(AsciCode2 - 65)));
                AsciConverted = (AsciConverted%26);
                Console.WriteLine(AsciConverted);
                AsciConverted = (AsciConverted*FirstInverse);
                Console.WriteLine($"AsciConverted PreMod: {AsciConverted}");
                AsciConverted = (AsciConverted%26);
                Console.WriteLine($"AsciConverted: {AsciConverted}");

                AsciConvertedUp = ((-ThirdInt*(AsciCode - 65)) + (FirstInt*(AsciCode2 - 65)));
                Console.WriteLine(AsciConvertedUp);
                AsciConvertedUp = (AsciConvertedUp%26);

                AsciConvertedUp = (AsciConvertedUp*FirstInverse);
               // Console.WriteLine(AsciConvertedUp);
                //Console.WriteLine($"AsciConvertedup PreMod: {AsciConvertedUp}");
                AsciConvertedUp = (AsciConvertedUp%26);
                //Console.WriteLine($"AsciConvertedup: {AsciConverted}");

                if (AsciConverted < 0)
                {
                    AsciConverted = AsciConverted + 26;
                    Console.WriteLine("REMOVED NEGATIVE ON CHARACTER 1");
                }
                if (AsciConvertedUp < 0)
                {
                    AsciConvertedUp = AsciConvertedUp + 26;
                    Console.WriteLine("REMOVED NEGATIVE ON CHARACTER 2");

                }
                char AsciChar = (char) (AsciConverted+65);
                Console.WriteLine(AsciChar);
                char AsciConvertedUpChar = (char) (AsciConvertedUp+65);
                Console.WriteLine(AsciConvertedUpChar);

                //Console.WriteLine(AsciConvertedUp);
                //This is cursed big time
            }
            break;

        
        default:
            break;
            
            
        
        }

    }
        Console.ReadLine();
