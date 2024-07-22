// See https://aka.ms/new-console-template for more information
/*
Step 1: Select What Type Of Calculation User Wants.
Step 2: Let The User Give The Vector Values (x = blah, y = blah blah)
Step 3: Repeat For How Ever Many Values Required
Step 3.1: Length: SQRT(A^2 + B^2) = Length
Step 3.2: Scalar Multiplication: X(A + B)
Step 3.3: Addition And Subtraction Of Vectors: (A + C), (B + C) 
*/
string UserChoice = "";
string UserChoice1 = "";
int[] VecValues = {0,0,0,0};
//int Result = 0;





Console.WriteLine("Vector Calculator");
Selector();

void Selector()
{
    Console.WriteLine("Select Your Calculation");
    Console.WriteLine("1. Length Of Vector");
    Console.WriteLine("2. Scalar Multiplication Of Vector");
    Console.WriteLine("3. Addition Of Vector");
    UserChoice = Console.ReadLine();
    switch(UserChoice)
    {
        case "1":
            Console.WriteLine("Length");
            Console.WriteLine("Are You Sure?");
            Console.WriteLine("Y/N");
            UserChoice1 = Console.ReadLine();
            UserChoice1 = UserChoice1.ToUpper();
            if (UserChoice1 == "Y")
            {
                Console.WriteLine(":)");
                Console.WriteLine("Please Enter 2 Points To Form One Vectors (a,b)");
                VecValues = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    VecValues[i] = Convert.ToInt32(Console.ReadLine());
                }
                VectorLength(VecValues);
                Console.WriteLine("TEST");
            }
            else
            {
                Selector();
            }
            break;
        case "2":
            Console.WriteLine("Scalar");
            Console.WriteLine("Are You Sure?");
            Console.WriteLine("Y/N");
            UserChoice1 = Console.ReadLine();
            UserChoice1 = UserChoice1.ToUpper();
            if (UserChoice1 == "Y")
            {
                Console.WriteLine(":)");
                Console.WriteLine("Please Enter 2 Points To Form One Vectors (a,b)");
                VecValues = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    VecValues[i] = Convert.ToInt32(Console.ReadLine());
                }
                VectorMult(VecValues);
                
            }
            else
            {
                Selector();
            }
            break;
        case "3":
            Console.WriteLine("Addition");
            Console.WriteLine("Are You Sure?");
            Console.WriteLine("Y/N");
            UserChoice1 = Console.ReadLine();
            UserChoice1 = UserChoice1.ToUpper();
            if (UserChoice1 == "Y")
            {
                Console.WriteLine(":)");
                Console.WriteLine("Please Enter 4 Points To Form Two Vectors (a,b) (c,d)");
                VecValues = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    VecValues[i] = Convert.ToInt32(Console.ReadLine());
                }
                VectorAdd(VecValues);
            }
            else
            {
                Selector();
            }
            break;
    }


}


int[] VectorLength(int[] VecValues)
{
    Console.WriteLine("VecLength");
    double VecLength;
    VecLength = (VecValues[0]*VecValues[0] + VecValues[1]*VecValues[1]);
    Convert.ToDouble(VecLength);
    VecLength = Math.Sqrt(VecLength);
    Console.WriteLine(VecLength);

    return VecValues;
}
int[] VectorMult(int[] VecValues)
{
    Console.WriteLine("VecScalar");
    int VecScalar;
    Console.WriteLine("Enter Scalar Value");
    VecScalar = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 2; i++)
    {
        VecValues[i] = (VecValues[i]*VecScalar);
        //Console.WriteLine(VecValues[i]);
    }
    Console.WriteLine($"({VecValues[0]},{VecValues[1]})");

return VecValues;
}
int[] VectorAdd(int[] VecAmount)
{
    Console.WriteLine("VecAddition");
    int[] VecAdd = new int[2];
    VecAdd[0] = (VecValues[0] + VecValues[2]);
    VecAdd[1] = (VecValues[1] + VecValues[3]);
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine(VecAdd[i]);
    }
    

return VecValues;
}
