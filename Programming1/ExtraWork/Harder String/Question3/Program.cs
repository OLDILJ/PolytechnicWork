// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string sentence = Console.ReadLine();
char[] chararray = sentence.ToCharArray();
char[] reversed = chararray.Reverse().ToArray();
string rsentence = new string(reversed);

if (rsentence == sentence)
{
    Console.WriteLine("PALINDROME DETECTED :)");
    Console.WriteLine($"{rsentence} is a palindrome of {sentence}");
}
else
{
    Console.WriteLine("No PALINDROME Found :(");
}