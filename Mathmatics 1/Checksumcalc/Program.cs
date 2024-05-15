// See https://aka.ms/new-console-template for more information
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

        break;}
