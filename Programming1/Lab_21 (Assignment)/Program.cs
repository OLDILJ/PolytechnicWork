namespace testProject
{
    public struct FamFeudPlayers
    {
        public string FName;
        public string LName;
        public string Interest;
    }
    class Program
    {
        static readonly string textFile = @"names.txt";
        static void Main(string[] args)
        {
            //Console.WriteLine("ClosingFile");

            FamFeudPlayers[] Players = new FamFeudPlayers[27];
            //vector<string> FamFeudPlayers;
            Random rand = new Random();
            int total = 100;
            int IntSize = 5;
            int[] nums;
            int PlayerCharactersMade = 0;
            int StartedGame = 0;
            string PlayerChoice;
            StreamReader si = new StreamReader("interest.txt");
            for (int i = 0;i <= 26; i++)
            {
                //Players[i].FName = sr.ReadLine();
                //Players[i].LName = sr.ReadLine();
                //Players[i].Address = "Dunedin";
                Players[i].Interest = si.ReadLine();
                //Console.WriteLine(Players[i].FName);
                //Console.WriteLine(Players[i].LName);
                //Console.WriteLine(Players[i].Address);
                //Console.WriteLine(Players[i].team);
                //i++;
            }
            si.Close();

            Console.WriteLine("Welcome To Family Feud");
            Console.WriteLine("Before We Begin Please Type {Y} To Take Part In This Game");
            PlayerChoice = Console.ReadLine();
            switch(PlayerChoice)
            {
                case "y" or "Y":
                    Console.WriteLine("WELCOME");
                    Console.WriteLine("Type {Y} To Manually Define Your Players");
                    PlayerChoice = Console.ReadLine();
                    switch(PlayerChoice)
                    {
                        case "y" or "Y":
                        PlayerCharactersMade = 2;
                        PlayerDefining();
                        StartGame();
                        break;
                        default:
                        TextReader();
                        StartGame();
                        break;


                    }
                    
                    break;
                default:
                    Console.WriteLine("Sorry To Hear That Come Again Another Time!");
                    end();
                    break;
            }
            

            void PlayerDefining()
            {
                //step 1 create a characters details
                //step 2 increment the made characters by 2 (to cover first and last name)
                //step 3 ask if they want to make another character
                Console.WriteLine($"Please enter Contestant #{PlayerCharactersMade-1}'s FIRST Name");
                Players[PlayerCharactersMade-1].FName = Console.ReadLine();
                Console.WriteLine($"Please enter Contestant #{PlayerCharactersMade-1}'s LAST Name");
                Players[PlayerCharactersMade-1].LName = Console.ReadLine();
                Console.WriteLine($"Please enter Contestants #{PlayerCharactersMade-1}'s INTEREST");
                Players[PlayerCharactersMade-1].Interest = Console.ReadLine();

            }
            int[] RNGToSum(int IntSize, int Total)
            {
                {
                    nums = new int[IntSize];
                    for (int i = 0; i < IntSize; i++)
                    {
                        int sum = nums.Sum();
                        nums[i] = rand.Next(0,(Total - sum));
                        Console.WriteLine($"number #{i} generated");
                    }
                    int sum1 = nums.Sum();
                    nums[IntSize-1] = (Total - sum1);
                }
                return nums;
            }
            void TextReader()
            {
            StreamReader sr = new StreamReader("names.txt");
            for (int i = (PlayerCharactersMade);i <= 26; i++)
            {
                Players[i].FName = sr.ReadLine();
                Players[i].LName = sr.ReadLine();
                //Players[i].Address = "Dunedin";
                //Players[i].team = rand.Next(1,5);
                Console.WriteLine(Players[i].FName);
                Console.WriteLine(Players[i].LName);
                //Console.WriteLine(Players[i].Address);
                //Console.WriteLine(Players[i].team);
                //i++;
            }
            sr.Close();
            Console.WriteLine("ClosingFile");
            }
            void CustomDisplay()
            {
                Console.WriteLine("TEST");
                
                for (int i = 0;i <= 26; i++)
                {
                    Console.Write(Players[i].FName.PadRight(10));
                    Console.Write(Players[i].LName.PadLeft(20));
                    Console.WriteLine(Players[i].Interest.PadLeft(30));
                    //Console.WriteLine(Convert.ToString(students[i].team).PadLeft(20));
                    //Console.WriteLine(i);
                }
            }
            //sr.Close();
            void StartGame()
            {
                Console.WriteLine("WELCOME TO FAMILY FEUD");
                Console.WriteLine("IM YOUR HOST FEUD GUY");
                Console.WriteLine("HERE ARE OUR CONTESTANTS FOR THE DAY");
                CustomDisplay();


            }






            void end()
            {
                if (StartedGame == 1)
                {
                    Console.WriteLine("Thanks For Playing");
                }
                else
                {
                    Console.WriteLine("Boring");
                    FIN();
                }
            }



            
        }
    static void FIN()
    {
        Console.ReadLine();
    }
    }

}
/*
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
*/