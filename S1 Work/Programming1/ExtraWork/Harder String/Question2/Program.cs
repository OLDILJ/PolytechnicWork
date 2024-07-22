// See https://aka.ms/new-console-template for more information
Console.WriteLine("PLEASE ENTER A SENTENCE");
string sentence = Console.ReadLine();
string newsentence = sentence.Replace(' ', '*');
Console.WriteLine(newsentence);