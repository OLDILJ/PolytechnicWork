// See https://aka.ms/new-console-template for more information
Console.WriteLine("WELCOME TO PALINDROME DETECTOR V0.1!");
Console.WriteLine("PLEASE WRITE A PALINDROME");

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
    Console.WriteLine($"{sentence} is not a palindrome :(");
}