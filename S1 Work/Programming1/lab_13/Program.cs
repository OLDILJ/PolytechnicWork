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
/*
Array.Sort(dArray);
foreach (char count in dArray)
{
    int index =+ 1
        if(dArray.char = dArray.char)
        {

        }

}
*/
int index = 0;
int repeatingchar = 0;
int repeatingcharsavecount = 0;
int check = 0;
string sentence = "";
sentence = Console.ReadLine();
Console.WriteLine($"{sentence}");
char beforecount = ' ';
char[] dArray = sentence.ToCharArray();
string[] repeatingcharsave = new string[sentence.Length];


Array.Sort(dArray);
foreach (char count in dArray)
{
    //Console.WriteLine($"{count} ");
    //Console.WriteLine("INDEX ABOVE 1");
    
     if (index >= 1)
    {
        beforecount = dArray[(index-1)];
        
        Console.WriteLine($"{beforecount} ");
        if (beforecount == count)
        {
            Console.WriteLine("MATCH");
            repeatingchar++;
            //Console.WriteLine(repeatingchar);
        }
        else
        {
            Console.WriteLine("!Match");
            Console.WriteLine("SavingReatingCharCount");
            repeatingcharsave.SetValue(value: ($"{beforecount} {repeatingchar+1}"), index: repeatingcharsavecount);
            Console.WriteLine(repeatingcharsavecount);
            repeatingcharsavecount++;
            repeatingchar = 0;
            //Console.WriteLine(repeatingchar);
        }
        if (index == sentence.Length - 1)
        {
            Console.WriteLine("LASTONEEMERGENCYSAVE");
            repeatingcharsave.SetValue(value: ($"{beforecount} {repeatingchar+1}"), index: repeatingcharsavecount);
            Console.WriteLine(repeatingcharsavecount);
            repeatingcharsavecount++;
            /*var repeatcharList = repeatingcharsave.ToList();

            repeatcharList.RemoveAll(x => x == check);

            repeatingcharsave = repeatcharList.ToArray();*/

            foreach(var item in repeatingcharsave)
            {
                if (item != null)
                {
                Console.WriteLine(item);
                }
            }

        }
        
    }
    index += 1;
}
