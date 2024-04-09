// See https://aka.ms/new-console-template for more information
//char[] loweralphabet = new char[26];
//loweralphabet = ['abcdefghijklmnopqrstuvwxyz'];
string loweralphabet = ("abcdefghijklmnopqrstuvwxyz");
string upperalphabet = loweralphabet.ToUpper();
//string() loweralphabet = new string [26];
//loweralphabet = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"];

//string[] upperalphabet = new string [26];
//upperalphabet = loweralphabet.ToUpper();

int[] lowercount = new int[26];

int[] uppercount = new int[26];

/*
Step 1 Create four strings, two for upper and lower case, two for position in respective alphabet 
Step 2 Read a sentence given by the user
Step 3 check how many times a part of either alphabet is contained in a sentence 
Step 4 increment the respective count in the right array.
Step 5 Print to screen
*/
// lowercount.loweralphabet(IndexOf(i))
string sentence = "";
sentence = Console.ReadLine();
int index = 0;
foreach (char i in sentence) // check if its an upper or lower case char
{
    if (Char.IsUpper(i))
    {
        uppercount[upperalphabet.IndexOf(i)] += 1;
    }
    if (Char.IsLower(i))
        lowercount[loweralphabet.IndexOf(i)] += 1;
    else
        Console.WriteLine("?");
    //if (upperalphabet.Contains(i););
    //{
        //uppercount[upperalphabet.IndexOf(i)] += 1;
    //}
    //else
    //{
        //Console.WriteLine(i);
        //Console.WriteLine(loweralphabet.IndexOf(i)); // THIS IS THE GOOD LINE
        //lowercount[loweralphabet.IndexOf(i)] += 1;
        //Console.WriteLine(sentence.IndexOf(i));
    //}
}
for (int i = 0; i < lowercount.Length; i++)
{
    Console.WriteLine($"{loweralphabet[i]} {lowercount[i]}");
}
for (int i = 0; i < uppercount.Length; i++)
{
    Console.WriteLine($"{upperalphabet[i]} {uppercount[i]}");
}
//Console.WriteLine(loweralphabet);
//Console.WriteLine(upperalphabet);