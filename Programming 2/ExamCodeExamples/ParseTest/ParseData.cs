public class ParseTest
{
    enum Edays {Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};

    public static void Main()
    {
        string CurrentDay = "Saturday";
        Edays CurDay = (Edays) Enum.Parse(typeof(Edays), CurrentDay);
        Console.WriteLine($"{(int)CurDay}");
    }
}