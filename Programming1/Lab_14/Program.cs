using System.Globalization;

int SelectedAnswer = 0;
Console.WriteLine("Welcome to LAB 14");
Console.WriteLine("Please select your part");

Console.WriteLine("1. Sentence Splitter");
Console.WriteLine("2. Sentence Word Adder");
Console.WriteLine("3. Sentence Word Adder+");
Console.WriteLine("4. Char E to Y converter");
Console.WriteLine("5. Padding Test");
Console.WriteLine("6. Birthday Extractor");
Console.WriteLine("7. Sentence Word Adder++");
SelectedAnswer = Convert.ToInt32(Console.ReadLine());
switch (SelectedAnswer)
{
    case 1:
        Console.WriteLine("Sentence Splitter");
        Console.WriteLine("Please enter a sentence to be split");
        string sentence = "";
        sentence = Console.ReadLine();
        string[] split = sentence.Split(' ','/',',');
        foreach (string item in split)
        {
            Console.WriteLine(item);
        }
        break;
    case 2:
        Console.WriteLine("Sentence Word Adder");
       // Console.WriteLine("Please enter a sentence to be split");
        string sentence2 = " the quick brown fox jumps over the lazy dog ";
        string sentenceAdder = sentence2.Insert(11, "hairy ");
        string SentenceReplace = sentenceAdder.Replace("dog","Chicken");
        string SenTrim = SentenceReplace.Trim();
        Console.WriteLine(sentence2);
        Console.WriteLine(SenTrim);

        //sentence = Console.ReadLine();
        //string[] split2 = SenTrim.Split(' ','/',',');
        /*foreach (string item in SenTrim)
        {
            char.ToUpper(item[0]);
            Console.Write(item);
        }*/
        break;
    
    case 3:
        Console.WriteLine("Sentence Word Adder+");
       // Console.WriteLine("Please enter a sentence to be split");
        string sentence3 = " the quick brown fox jumps over the lazy dog ";
        string sentenceAdder2 = sentence3.Insert(11, "hairy ");
        string SentenceReplace2 = sentenceAdder2.Replace("dog","Chicken");
        string SenTrim2 = SentenceReplace2.Trim();
        Console.WriteLine(sentence3);
        Console.WriteLine(SenTrim2);
        Console.WriteLine(SenTrim2.ToUpper());
        Console.WriteLine(SenTrim2.ToLower());
        break;
    case 4:
        Console.WriteLine("Char E to Y converter");
        break;
    case 5:
        Console.WriteLine("Padding Test");
        break;
    case 6:
        Console.WriteLine("Birthday Extractor");
        break;
    case 7:
        Console.WriteLine("Sentence Word Adder++");
        string sentence4 = " the quick brown fox jumps over the lazy dog ";
        string sentenceAdder3 = sentence4.Insert(11, "hairy ");
        string SentenceReplace3 = sentenceAdder3.Replace("dog","chicken");
        string SenTrim3 = SentenceReplace3.Trim();
        string[] split3 = SenTrim3.Split(' ','/',',');
        string FinString = "";
        string Finstring2 = "";
        //TextInfo myTI = new CultureInfo("en-NZ",false).TextInfo;
        //string concat;
        foreach (string item in split3)
        {
            FinString = String.Concat(char.ToUpper(item[0]) + item.Substring(1));
            Finstring2 = (Finstring2 + FinString + " ");
            //item[0].ToUpper(){item.Substring(1)}
            //Console.Write(char.ToUpper(item[0]));
            //Console.WriteLine(FinString.IndexOf(item[0]));
            //Console.WriteLine(item[0]);
            /*string result = string.Concat(item);
            result = result.Replace(item[0],char.ToUpper(item[0]));
            if (result.IndexOf(item[0]) != result.LastIndexOf(item[0]));
            {
                result.ToLower

            }       */
            //Console.WriteLine(SenTrim3 = SenTrim3.Replace(char.ToUpper(item[0]),));
            //Console.WriteLine(item);
            //FinString = ($"{item} ");
            //Console.Write(FinString);
            
            
            Console.WriteLine(FinString);
            
            
        }
        //string Finstring2 = string.Join("", FinString);
        //FinString = myTI.ToTitleCase(FinString);
        //Console.WriteLine(sentence4);
        //Console.WriteLine(SenTrim3);
        Console.WriteLine(Finstring2);

        //sentence = Console.ReadLine();
        //string[] split2 = SenTrim.Split(' ','/',',');
        /*foreach (string item in SenTrim)
        {
            char.ToUpper(item[0]);
            Console.Write(item);
        }*/
        break;

        break;
}
Console.WriteLine("Enter any key to exit");
Console.ReadLine();