namespace testProject
{
    public struct FamFeudPlayers
    {
        public string FName;
        public string LName;
        public string Interest;
        public string CombinedName;
    }
    class Program
    {
        static readonly string textFile = @"names.txt";
        public static void Main(string[] args)
        {
            //Console.WriteLine("ClosingFile");

            FamFeudPlayers[] Players = new FamFeudPlayers[27];
            //vector<string> FamFeudPlayers;
            Random rand = new Random();
            int total = 100;
            int IntSize = 5;
            int[] nums;
            string[] team1;
            string[] team2;
            int[] team1Score;
            int[] team2Score;
            int PlayerCharactersMade = 0;
            int StartedGame = 0;
            string PlayerChoice;
            string[] PotentialInterests;
            string[] Questions;
            Questions = new string [10]
            PotentialInterests = new string[150];
            StreamReader si = new StreamReader("interest.txt");
            
            for (int i = 0;i != 150; i++)
            {
                //Players[i].FName = sr.ReadLine();
                //Players[i].LName = sr.ReadLine();
                //Players[i].Address = "Dunedin";

                //Players[i].Interest = si.ReadLine();

                PotentialInterests[i] = si.ReadLine();

                //Console.WriteLine(Players[i].FName);
                //Console.WriteLine(Players[i].LName);
                //Console.WriteLine(Players[i].Address);
                //Console.WriteLine(Players[i].team);
                //i++;
            }
            si.Close();
            Random.Shared.Shuffle(PotentialInterests);
            for (int i = 0;i != 27; i++)
            {
                //Players[i].FName = sr.ReadLine();
                //Players[i].LName = sr.ReadLine();
                //Players[i].Address = "Dunedin";

                //Players[i].Interest = si.ReadLine();
                //Players[i].CombinedName = " ";
                

                Players[i].Interest = PotentialInterests[i];

                //Console.WriteLine(Players[i].FName);
                //Console.WriteLine(Players[i].LName);
                //Console.WriteLine(Players[i].Address);
                //Console.WriteLine(Players[i].team);
                //i++;
            }

            StreamReader si1 = new StreamReader("question.txt");


            for (int i = 0;i != 10; i++)
            {
                //Players[i].FName = sr.ReadLine();
                //Players[i].LName = sr.ReadLine();
                //Players[i].Address = "Dunedin";

                //Players[i].Interest = si.ReadLine();

                Questions[i] = si1.ReadLine();

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
            for (int i = 0; i != 27; i++)
            {
                Players[i].CombinedName = String.Concat(Players[i].FName," ",Players[i].LName);
                //Console.WriteLine(Players[i].CombinedName);
            }
            string[] TempArray = new string[27];
            for (int i = 0; i != 27; i++)
            {
                TempArray[i] = Players[i].CombinedName;
            }
            Random.Shared.Shuffle(TempArray);
            for (int i = 0; i != 27; i++)
            {
                //TempArray[i] = Players[i].CombinedName;
                Players[i].CombinedName = TempArray[i];
                Console.WriteLine(Players[i].CombinedName);

            }
            /*
            for (int i = 0; i != 13; i++)
            {
                TempArray[i] = Players[rand.Next(0,13)].CombinedName;
                Console.WriteLine(TempArray[i]);
            }
            for (int i = 0; i != 13; i++)
            {
                if (Players[i].CombinedName != TempArray[i])
                {
                    Players[i].CombinedName = TempArray[i];
                }
                    //Players[rand.Next(0,27)].CombinedName = TempArray[i];
                //Players[rand.Next(0,27)].CombinedName = TempArray[i];
                //Players[rand.Next(0,27)].CombinedName = Players[i].CombinedName;
                Console.WriteLine(Players[i].CombinedName);
                
                
            }
            */
            Console.WriteLine("ClosingFile");
            }
            
            void CustomDisplay()
            {
                //Console.WriteLine("TEST");
                
                for (int i = 0;i <= 26; i++)
                {
                    Console.Write(Players[i].FName.PadRight(10));
                    Console.Write(Players[i].LName.PadLeft(20));
                    Console.WriteLine(Players[i].Interest.PadLeft(30));
                    //Console.WriteLine(Convert.ToString(students[i].team).PadLeft(20));
                    //Console.WriteLine(i);
                }
            }
            void DisplayTeams()
            {
                string tempscore = "";
                Console.WriteLine("TEAM 1:");
                for (int i = 0; i < 9; i++)
                {
                    tempscore = team1Score[i].ToString();
                    

                    Console.Write(team1[i].PadLeft(25));
                    Console.WriteLine(tempscore.PadLeft(5));

                    //Console.Write(Players[i].LName.PadLeft(20));
                    //Console.WriteLine(Players[i].Interest.PadLeft(30));
                    //Console.WriteLine(Convert.ToString(students[i].team).PadLeft(20));
                    //Console.WriteLine(i);
                }
                Console.WriteLine("TEAM 2:");
                for (int i = 0; i < 9; i++)
                {
                    tempscore = team2Score[i].ToString();
                    Console.Write(team2[i].PadLeft(25));
                    Console.WriteLine(tempscore.PadLeft(5));
                }
                
            }
            //sr.Close();
            void StartGame()
            {
                Console.WriteLine("WELCOME TO FAMILY FEUD");
                Console.WriteLine("IM YOUR HOST FREDDY FEUD");
                Console.WriteLine("HERE ARE OUR CONTESTANTS FOR THE DAY");
                CustomDisplay();
                Console.WriteLine("LETS SELECT 10 LUCKY PEOPLE TO TAKE PART IN TODAYS GAME");
                TeamSort();
                DisplayTeams();
                Console.WriteLine("HOW MANY ROUNDS WOULD YOU LIKE TO PLAY TODAY");
                int roundcount = Convert.ToInt32(Console.ReadLine());
                GameplayLoop(roundcount, team1Score, team2Score);


            }
            int[] GameplayLoop(int roundcount,int[] team1Score, int[] team2Score)
            {
                //step 1 increment round counter by 1
                //step 2 grab next thing in question array
                //step 3 assign values to 6 questions using RngToSum()
                //step 4 let each team guess 3 times if they get it right they get points else they get nothing
                //step 5 the other team can "steal" all of their points by guessing any of the remaining answers
                //step 6 tally up each teams points
                //step 7 display points and loop.
                int rCount = roundcount;
                int i = 0;
                int currentteam = 1;
                while (i < rCount)
                {
                    Console.WriteLine($"WELCOME TO ROUND {i+1}");
                    Console.WriteLine("LETS LOOK HOW THE TEAMS ARE DOING");
                    DisplayTeams();
                    Console.WriteLine($"HERE IS QUESTION #{i+1}");
                    if (currentteam == 1)
                    {
                        team1Score[i%9] += 1;
                    }
                    if (currentteam == 2)
                    {
                        team2Score[i%9] += 1;
                    }

                    //Console.WriteLine(question);
                    
                    
                    //Console.WriteLine(i);
                    i = i + 1;
                }
                //roundcount = rCount;
                //return roundcount;
                return team1Score;

                


            }
            string[] TeamSort()
            {
                //step 1 organize players into their name
                //step 2 Shuffle list
                //step 3 Grab 10 random numbers from list
                //step 4 put into team 1 then team 2.
                //ConCatPlayers();
                team1 = new string[9];
                team2 = new string[9];
                team1Score = new int[9];
                team2Score = new int[9];
                
                for (int i = 0; i != 9; i++)
                {
                    team1[i] = Players[i].CombinedName;
                    Console.WriteLine(team1[i]); 
                }
                for (int i = 0; i != 9; i++)
                {
                    team2[i] = Players[i+10].CombinedName;
                    Console.WriteLine(team2[i]);
                }
                

                
                return team1;
                return team2;
            }
        

            void ConCatPlayers()
            {
                /*
                for (int i = 0; i <= 26; i++)
                {
                    Players[i].CombinedName = String.Concat(Players[i].FName," ",Players[i].LName);
                    Console.WriteLine(Players[i].CombinedName);
                    
                }
                string[] tempteam = {Players.CombinedName};
                //return Players.CombinedName;
                */
                
                
                
                
                

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
            static void FIN()
            {
                Console.ReadLine();
            }
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