// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Step 1: Get string from user
Step 2: Split String. 
Step 3: Compare Split.length to find the longest and smallest word.
*/
Console.WriteLine("PLEASE ENTER A SENTENCE");
string sentence = Console.ReadLine();
string[] splitsentence = sentence.Split(' ');
Array.Sort(splitsentence, (x, y) => x.Length.CompareTo(y.Length));
/*
foreach (string test in splitsentence)
{
    Console.WriteLine(test);
}
*/
var first = splitsentence.First();
var last = splitsentence.Last();
Console.WriteLine($"The Longest word in the sentence is {last}");
Console.WriteLine($"The Shortest word in the sentence is {first}");