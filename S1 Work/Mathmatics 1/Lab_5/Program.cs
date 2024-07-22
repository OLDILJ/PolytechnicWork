// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
int a = 0;
int b = 0;
int c = 0;
*/
Random rand = new Random();
List<int> numbers = new List<int>();
bool allEqual = false;
int UserResponse = 0;

Console.WriteLine("PLEASE SELECT YOUR LOGIC GATE");
Console.WriteLine("1. AND GATE");
Console.WriteLine("2. NAND GATE");
Console.WriteLine("3. NOR GATE");
Console.WriteLine("4. NOT GATE (ONE INPUT ONLY)");
Console.WriteLine("5. OR GATE");
Console.WriteLine("6. XNOR GATE");
Console.WriteLine("7. XOR GATE");
string UserChoice = "";
UserChoice = Console.ReadLine();
switch (UserChoice)
{
    case "1" or "1.":
        Console.WriteLine("Please Enter The Amount Of Inputs");
        UserResponse = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse)
        {
            numbers.Add(rand.Next(0,2)); 
            //UserResponse2 = UserResponse2 + 1;
            //Console.WriteLine("One Slot Filled");
            //Console.WriteLine(UserResponse);
            //Console.WriteLine(numbers.Count);
        }
        int[] NumArray = numbers.ToArray();


        ANDGate(NumArray);
        break;
    case "2" or "2.":
        Console.WriteLine("Please Enter The Amount Of Inputs");
        UserResponse = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse)
        {
            numbers.Add(rand.Next(0,2)); 
            //UserResponse2 = UserResponse2 + 1;
            //Console.WriteLine("One Slot Filled");
            //Console.WriteLine(UserResponse);
            //Console.WriteLine(numbers.Count);
        }
        int[] NumArray2 = numbers.ToArray();

        NANDGate(NumArray2);
        break;

    case "3" or "3.":
        Console.WriteLine("Please Enter The Amount Of Inputs");
        UserResponse = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse)
        {
            numbers.Add(rand.Next(0,2)); 
            //UserResponse2 = UserResponse2 + 1;
            //Console.WriteLine("One Slot Filled");
            //Console.WriteLine(UserResponse);
            //Console.WriteLine(numbers.Count);
        }
        int[] NumArray3 = numbers.ToArray();
        NORGate(NumArray3);
        break;

    case "4" or "4.":
        Console.WriteLine("Please Enter The Amount Of Inputs");
        UserResponse = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse)
        {
            numbers.Add(rand.Next(0,2)); 
            //UserResponse2 = UserResponse2 + 1;
            //Console.WriteLine("One Slot Filled");
            //Console.WriteLine(UserResponse);
            //Console.WriteLine(numbers.Count);
        }
        int[] NumArray4 = numbers.ToArray();
        NOTGate(NumArray4);
        break;

    case "5" or "5.":
        Console.WriteLine("Please Enter The Amount Of Inputs");
        UserResponse = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse)
        {
            numbers.Add(rand.Next(0,2)); 
            //UserResponse2 = UserResponse2 + 1;
            //Console.WriteLine("One Slot Filled");
            //Console.WriteLine(UserResponse);
            //Console.WriteLine(numbers.Count);
        }
        int[] NumArray5 = numbers.ToArray();
        ORGate(NumArray5);
        break;

    case "6" or "6.":
        Console.WriteLine("Please Enter The Amount Of Inputs");
        UserResponse = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse)
        {
            numbers.Add(rand.Next(0,2)); 
            //UserResponse2 = UserResponse2 + 1;
            //Console.WriteLine("One Slot Filled");
            //Console.WriteLine(UserResponse);
            //Console.WriteLine(numbers.Count);
        }
        int[] NumArray6 = numbers.ToArray();
        XNORGate(NumArray6);
        break;

    case "7" or "7.":
        Console.WriteLine("Please Enter The Amount Of Inputs");
        UserResponse = Convert.ToInt32(Console.ReadLine());
        while (numbers.Count < UserResponse)
        {
            numbers.Add(rand.Next(0,2)); 
            //UserResponse2 = UserResponse2 + 1;
            //Console.WriteLine("One Slot Filled");
            //Console.WriteLine(UserResponse);
            //Console.WriteLine(numbers.Count);
        }
        int[] NumArray7 = numbers.ToArray();
        XORGate(NumArray7);
        break;
    default:
        Console.WriteLine("UNKNOWN");
        break;





}

void ANDGate (params int[] NumArray)
{
    allEqual = true;
    for (int i = 0; i < NumArray.Length; i++)
    {
        Console.WriteLine($"INPUT #{i} = {NumArray[i]}");
        if (NumArray[i] == 1)
        {
            allEqual = false;
            //Console.WriteLine("FALSE");
        } 
    }
    Console.WriteLine(allEqual);
}

void NANDGate (params int[] NumArray2)
{
    allEqual = true;
    for (int i = 0; i < NumArray2.Length; i++)
    {
        Console.WriteLine($"INPUT #{i} = {NumArray2[i]}");
        if (NumArray2[i] == 0)
        {
            allEqual = false;
            //Console.WriteLine("FALSE");
        } 
    }
    Console.WriteLine(allEqual);
}
void NORGate (params int[] NumArray3)
{
    
    allEqual = true;
    for (int i = 0; i < NumArray3.Length; i++)
    {
        Console.WriteLine($"INPUT #{i} = {NumArray3[i]}");
        if (NumArray3[i] == 1)
        {
            allEqual = false;
            //Console.WriteLine("FALSE");
        } 
    }
    Console.WriteLine(allEqual);
}
void NOTGate (params int[] NumArray4)
{// Invert Input for Output 1 -> 0, 0 -> 1.
    allEqual = false;
    for (int i = 0; i < NumArray4.Length; i++)
    {
        Console.WriteLine($"INPUT #{i} = {NumArray4[i]}");
        if (NumArray4[i] == 1)
        {
            allEqual = true;
            //Console.WriteLine("FALSE");
        } 
    }
    Console.WriteLine(allEqual);
}
void ORGate (params int[] NumArray5)
{
    allEqual = false;
    for (int i = 0; i < NumArray5.Length; i++)
    {
        Console.WriteLine($"INPUT #{i} = {NumArray5[i]}");
        if (NumArray5[i] == 0)
        {
            allEqual = true;
            //Console.WriteLine("FALSE");
        } 
    }
    Console.WriteLine(allEqual);
}
void XNORGate (params int[] NumArray6)
{
    allEqual = true;
    for (int i = 0; i < NumArray6.Length; i++)
    {
        Console.WriteLine($"INPUT #{i} = {NumArray6[i]}");
        if (NumArray6[i] == 1)
        {
            allEqual = false;
            //Console.WriteLine("FALSE");
        } 
    }
    Console.WriteLine(allEqual);
}
void XORGate (params int[] NumArray7)
{
    allEqual = true;
    for (int i = 0; i < NumArray7.Length; i++)
    {
        Console.WriteLine($"INPUT #{i} = {NumArray7[i]}");
        if (NumArray7[i] == 1)
        {
            allEqual = false;
            //Console.WriteLine("FALSE");
        } 
    }
    Console.WriteLine(allEqual);
}















    //// AND GATE ATTEMPTS
    //Console.WriteLine(allEqual);
    //return (allEqual);
    /*
    if (NumArray.All(x => x == NumArray[0]))
    {
        Console.WriteLine("TRUE");
    }
    */
    /*
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        if (n1 == n2 && n2 == n3 && andcount)
        {
            Console.WriteLine("ANDGATE 3 MATCH");
        }
        if (n1 == n2)
        {
            Console.WriteLine("ANDGATE N1 N2 MATCH");
        }
        if (n2 == n3)
        {
            Console.WriteLine("ANDGATE N2 N3 MATCH");
        }
        else
        {
            Console.WriteLine("NO ANDGATE MATCH");
        }
    */