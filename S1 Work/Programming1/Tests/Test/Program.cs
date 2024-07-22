//OLDILJ1 LOGAN J. OLDING 
Console.WriteLine("Hello, World!");
//rand Random = new Random();
int avg = 0;
int DayTotal = 0;
int ZeroDays = 0;
int InvalidDays = 0;
int InputDay = (-1);
//string Input = ("");
int ValidDays = 0;
int max = 0;
bool end = true;
while (end)
{
    Console.WriteLine("PLEASE ENTER TODAYS CASE COUNT");
    InputDay = Convert.ToInt32(Console.ReadLine());
    /*
    if (Input == ("-99"))
    {
        
    }
    else
    {
        InputDay = Convert.ToInt32(Input);
    }
    */

    if (InputDay == 0)
    {
        Console.WriteLine("ZERO CASE COUNT DAY");
        ZeroDays++;
    }    
    else if (InputDay > 0)
    {
        DayTotal =+ (DayTotal + InputDay);
        Console.WriteLine("VALID CASE COUNT");
        ValidDays++;
        if (InputDay > max)
        {
            max = InputDay;
        }
    }
    else if (InputDay == -99)
    {
        Console.WriteLine("EXIT CODE ACCEPTED");
        end = false;
        if (DayTotal > 0)
        {
            avg = (DayTotal/(ZeroDays + ValidDays));
        }
    }
    else
    {
        InvalidDays++; //= (InvalidDays + 1);
        Console.WriteLine("INVALID CASE COUNT");
    }

}
Console.WriteLine("FINISH");
Console.WriteLine(" ");
Console.WriteLine($"TOTAL CASE COUNT {DayTotal}");
Console.WriteLine($"ZERO CASE COUNT DAYS {ZeroDays}");
Console.WriteLine($"POSITIVE CASE COUNT DAYS {ValidDays}");
Console.WriteLine($"INVALID CASES RECIEVED {InvalidDays}");
Console.WriteLine($"AVG CASES PER DAY {avg}");
Console.WriteLine($"MAX DAILY CASES {max}");

