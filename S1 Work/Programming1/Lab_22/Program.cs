// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//StreamWriter sw = new StreamWriter(@"../../../test.txt");
//StreamWriter sw = new StreamWriter(@"test.txt");
//StreamReader sr = new StreamReader("names.txt");
//sw.Close();


namespace testProject
{
    public struct Students
    {
        public string FName;
        public string LName;
        public string Address;
        public int team;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Students[] students = new Students[27];
            Random rand = new Random();
            StreamReader sr = new StreamReader("names.txt");


            int i = 0;
            while (!sr.EndOfStream)
            {
                students[i].FName = sr.ReadLine();
                students[i].LName = sr.ReadLine();
                students[i].Address = "Dunedin";
                students[i].team = rand.Next(1,5);
                //Console.WriteLine(students[i].FName);
                //Console.WriteLine(students[i].LName);
                //Console.WriteLine(students[i].Address);
                //Console.WriteLine(students[i].team);
                i++;
            }
            





            //sr.Close();
            CustomDisplay();

            void CustomDisplay()
            {
                Console.WriteLine("TEST");
                
                for (int i = 0;i <= 26; i++)
                {
                    Console.Write(students[i].FName.PadRight(10));
                    Console.Write(students[i].LName.PadLeft(20));
                    Console.Write(students[i].Address.PadLeft(20));
                    Console.WriteLine(Convert.ToString(students[i].team).PadLeft(20));
                    //Console.WriteLine(i);
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("ourClass.txt");
            for (int o = 0;o <= 26; o++)
                {
                    sw.Write(students[o].FName.PadRight(10));
                    sw.Write(students[o].LName.PadLeft(20));
                    sw.Write(students[o].Address.PadLeft(20));
                    sw.WriteLine(Convert.ToString(students[o].team).PadLeft(20));
                    //Console.WriteLine(i);
                }
            sw.Close();



        }
    static void FIN()
    {
        Console.ReadLine();
    }
    }

}