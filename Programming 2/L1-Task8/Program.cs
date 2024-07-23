namespace L1_Task8;

class Program
{
    static void Main(string[] args)
    {
        string sentence = Console.ReadLine();
        char[] chararray = sentence.ToCharArray();
        char[] reversed = chararray.Reverse().ToArray();
        string rsent = new string(reversed);

        if (rsent == sentence)
        {
            Console.WriteLine($"{rsentence} is a palindrome of {sentence}");
        }
        else
        {
            Console.WriteLine($"false");
        }
    }
}
