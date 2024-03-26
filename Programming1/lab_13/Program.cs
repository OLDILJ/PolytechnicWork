// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Upper Case Counters
/*
{
    int upperA = 0;
    int upperB = 0;
    int upperC = 0;
    int upperD = 0;
    int upperE = 0;
    int upperF = 0;
    int upperG = 0;
    int upperH = 0;
    int upperI = 0;
    int upperJ = 0;
    int upperK = 0;
    int upperL = 0;
    int upperM = 0;
    int upperN = 0;
    int upperO = 0;
    int upperP = 0;
    int upperQ = 0;
    int upperR = 0;
    int upperS = 0;
    int upperT = 0;
    int upperU = 0;
    int upperV = 0;
    int upperW = 0;
    int upperX = 0;
    int upperY = 0;
    int upperZ = 0;
}
*/
//Lower Case Counters
/*
{
    int lowerA = 0;
    int lowerB = 0;
    int lowerC = 0;
    int lowerD = 0;
    int lowerE = 0;
    int lowerF = 0;
    int lowerG = 0;
    int lowerH = 0;
    int lowerI = 0;
    int lowerJ = 0;
    int lowerK = 0;
    int lowerL = 0;
    int lowerM = 0;
    int lowerN = 0;
    int lowerO = 0;
    int lowerP = 0;
    int lowerQ = 0;
    int lowerR = 0;
    int lowerS = 0;
    int lowerT = 0;
    int lowerU = 0;
    int lowerV = 0;
    int lowerW = 0;
    int lowerX = 0;
    int lowerY = 0;
    int lowerZ = 0;
}
*/
int repeatingchar = 0;
string sentence = "";
sentence = Console.ReadLine();
Console.WriteLine($"{sentence}");
char[] dArray = sentence.ToCharArray();
/*
foreach (char i in sentence)

{
    Console.WriteLine(i);
    Console.WriteLine(sentence.IndexOf(i));
}
/*
foreach (char d in sentence)
{
    string dString = d.ToString();
}
*/

// step 1 three vars: one main, one for comparator, one for total count
// step 2 
Array.Sort(dArray);
foreach (char count in dArray)
{
    int index =+ 1;

    Console.WriteLine($"{count} ");
    if (index >= 1)
    {
        Console.WriteLine("INDEX ABOVE 1");
        char beforecount = dArray[(index-1)];
        if (beforecount == count)
        {
            Console.WriteLine("MATCH");
            repeatingchar++;
            Console.WriteLine(repeatingchar);
        }
    }
}