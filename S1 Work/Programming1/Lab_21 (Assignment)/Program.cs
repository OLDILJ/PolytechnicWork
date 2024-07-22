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
            string[] Answers;
            Questions = new string [10];
            Answers = new string [40];
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

            StreamReader si1 = new StreamReader("Questions.txt");
            //Console.WriteLine("QUESTIONLOADINGBEGIN");


            for (int i = 0;i != 9; i++)
            {
                //Players[i].FName = sr.ReadLine();
                //Players[i].LName = sr.ReadLine();
                //Players[i].Address = "Dunedin";

                //Players[i].Interest = si.ReadLine();
                //Console.WriteLine("QUESTION LOADED");

                Questions[i] = si1.ReadLine();
                //Console.WriteLine(Questions[i]);
                

                //Console.WriteLine(Players[i].FName);
                //Console.WriteLine(Players[i].LName);
                //Console.WriteLine(Players[i].Address);
                //Console.WriteLine(Players[i].team);
                //i++;
            }
            si1.Close();

            StreamReader si2 = new StreamReader("Answers.txt");
            //Console.WriteLine("QUESTIONLOADINGBEGIN");


            for (int i = 0;i != 40; i++)
            {
                //Players[i].FName = sr.ReadLine();
                //Players[i].LName = sr.ReadLine();
                //Players[i].Address = "Dunedin";

                //Players[i].Interest = si.ReadLine();
                //Console.WriteLine("QUESTION LOADED");

                Answers[i] = si2.ReadLine();
                Console.WriteLine(Answers[i]);
                //Console.WriteLine(Questions[i]);
                

                //Console.WriteLine(Players[i].FName);
                //Console.WriteLine(Players[i].LName);
                //Console.WriteLine(Players[i].Address);
                //Console.WriteLine(Players[i].team);
                //i++;
            }
            si2.Close();
            
            

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
                        //PlayerCharactersMade = 2;
                        PlayerDefining();
                        StartGame();
                        end();
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
                TextReader();
                Console.WriteLine("PLEASE SELECT THE TEAM THAT YOU WANT TO CHANGE A MEMBER OF");
                //Console.WriteLine("1. TEAM 1 (PLAYER TEAM)");
                //Console.WriteLine("2. TEAM 2 (CPU TEAM)");
                //string UserTeamChoice = "";
                int UserPlayerChoice = 1;
                //Console.WriteLine("TEAM 1 SELECTED");
                Console.WriteLine("PLEASE SELECT A MEMBERS NUMBER FOLLOWED BY THEIR FIRST NAME, THEN THEIR LAST NAME, THEN THEIR INTEREST");
                Console.WriteLine("ENTER A UNKNOWN MEMBERS NUMBER TO EXIT");
                bool ContainsMember = false;

                //Better Version 
                // step 1 check if you have selected one of the 27 members
                // step 2 edit accordingly
                // step 3 if its out bounds then go to the main game.
                // step 4 (need to work on) force the rng to pick a modified member
                
                while (true)
                {
                    UserPlayerChoice = Convert.ToInt32(Console.ReadLine());
                    if (UserPlayerChoice <= 27)
                    {
                        Console.WriteLine($"MEMBER {Players[UserPlayerChoice].FName} {Players[UserPlayerChoice].LName} SELECTED PLEASE ENTER THEIR FIRST NAME");
                        Players[UserPlayerChoice].FName = Console.ReadLine();
                        Console.WriteLine("NOW ENTER THEIR LAST NAME");
                        Players[UserPlayerChoice].LName = Console.ReadLine();
                        Console.WriteLine("ENTER ANOTHER MEMBERS NUMBER");
                        //Console.WriteLine("NOW ENTER THEIR INTEREST");
                        //Players[UserPlayerChoice].Interest = Console.ReadLine();

                    }
                    else
                    {
                        break;
                    }
                        

                }
                
                /*
                //step 1 create a characters details
                //step 2 increment the made characters by 2 (to cover first and last name)
                //step 3 ask if they want to make another character
                Console.WriteLine($"Please enter Contestant #{PlayerCharactersMade-1}'s FIRST Name");
                Players[PlayerCharactersMade-1].FName = Console.ReadLine();
                Console.WriteLine($"Please enter Contestant #{PlayerCharactersMade-1}'s LAST Name");
                Players[PlayerCharactersMade-1].LName = Console.ReadLine();
                Console.WriteLine($"Please enter Contestants #{PlayerCharactersMade-1}'s INTEREST");
                Players[PlayerCharactersMade-1].Interest = Console.ReadLine();
                */

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
                //nums.sort();
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
                Console.WriteLine($"FOR A TOTAL SCORE OF {team1Score.Sum()}");
                Console.WriteLine("TEAM 2:");
                for (int i = 0; i < 9; i++)
                {
                    tempscore = team2Score[i].ToString();
                    Console.Write(team2[i].PadLeft(25));
                    Console.WriteLine(tempscore.PadLeft(5));
                }
                Console.WriteLine($"FOR A TOTAL SCORE OF {team2Score.Sum()}");

                if (team1Score.Sum() > team2Score.Sum())
                {
                    Console.WriteLine("LOOKS LIKE TEAM 1 IS IN THE LEAD");
                    Console.WriteLine("LETS SEE IF THEY CAN KEEP IT");
                }
                if (team2Score.Sum() > team1Score.Sum())
                {
                    Console.WriteLine("LOOKS LIKE TEAM 2 IS IN THE LEAD");
                    Console.WriteLine("LETS SEE IF THEY CAN KEEP IT");
                }
                
            }
            //sr.Close();
            void StartGame()
            {
                Console.WriteLine("WELCOME TO FAMILY FEUD");
                Console.WriteLine("IM YOUR HOST FREDDY FEUD");
                Console.WriteLine("HERE ARE OUR CONTESTANTS FOR THE DAY");
                CustomDisplay();
                Console.WriteLine("LETS SELECT 18 LUCKY PEOPLE TO TAKE PART IN TODAYS GAME");
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
                string UserAnswer = "";
                int rCount = roundcount;
                int i = 0;
                int currentteam = 1;
                int UserGuesses;
                int CorrectGuesses;
                int CpuGuesses;
                
                bool Answer1Guessed = false;
                bool Answer2Guessed = false;
                bool Answer3Guessed = false;
                bool Answer4Guessed = false;
                

                while (i < rCount)
                {
                    RNGToSum(4, 100);
                    UserGuesses = 3;
                    CorrectGuesses = 0;
                    CpuGuesses = 3;
                    Console.WriteLine($"WELCOME TO ROUND {i+1}");
                    Console.WriteLine("LETS LOOK HOW THE TEAMS ARE DOING");
                    DisplayTeams();
                    Console.ReadLine();
                    Console.WriteLine($"OUR CONTESTANTS FOR THIS ROUND IS {team1[i]} AND {team2[i]}");
                    Console.WriteLine($"HERE IS QUESTION #{i+1}");
                    /*
                    if (currentteam == 1)
                    {
                        team1Score[i%9] += 1;
                    }
                    if (currentteam == 2)
                    {
                        team2Score[i%9] += 1;
                    
                    This code works ^^
                    }
                    */
                    Console.WriteLine(Questions[i%9]);
                    while (UserGuesses >= 0)
                    {
                        if (CorrectGuesses == 4)
                        {
                            Console.WriteLine($"WONDERFUL CLEAN SWEEP {team1[i]}");
                            Console.WriteLine($"LETS MOVE ONTO THE NEXT ROUND");
                            break;
                        }
                        if (UserGuesses == 0)
                        {
                            Console.WriteLine($"BETTER LUCK NEXT TIME {team1[i]}");
                            Console.WriteLine($"NOW ITS {team2[i]}'s TURN TO GET SOME POINTS");
                            while (CpuGuesses >= 1)
                            {
                                int StealChance = rand.Next(1,10);
                                switch (StealChance)
                                {
                                    case 2 when Answer1Guessed == false:
                                    {
                                        Console.WriteLine("ANSWER 1 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[0]} POINTS!");
                                        team2Score[i] += nums[0];
                                        Console.WriteLine("TRY FOR MORE POINTS");
                                        break;

                                    }
                                    case 3 when Answer2Guessed == false:
                                    {
                                        Console.WriteLine("ANSWER 2 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[1]} POINTS!");
                                        team2Score[i] += nums[1];
                                        Console.WriteLine("TRY FOR MORE POINTS");
                                        break;

                                    }
                                    case 4 when Answer3Guessed == false:
                                    {
                                        Console.WriteLine("ANSWER 3 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[2]} POINTS!");
                                        team2Score[i] += nums[2];
                                        Console.WriteLine("TRY FOR MORE POINTS");
                                        break;

                                    }
                                    case 5 when Answer4Guessed == false:
                                    {
                                        Console.WriteLine("ANSWER 4 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[3]} POINTS!");
                                        team2Score[i] += nums[3];
                                        Console.WriteLine("TRY FOR MORE POINTS");
                                        break;
                                    }
                                    default:
                                    {
                                        Console.WriteLine("WRONG ANSWER");
                                        CpuGuesses -= 1;
                                        Console.WriteLine($"YOU HAVE {CpuGuesses} LEFT");
                                        break;
                                    }
                                    /*
                                    case (Answer1Guessed == false && StealChance = 2)
                                    {
                                        Console.WriteLine("ANSWER 1 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[0]} POINTS!");
                                        team2Score[i] += nums[0];
                                        Console.WriteLine("TRY FOR MORE POINTS");

                                    }
                                    case (Answer1Guessed == false && StealChance = 3)
                                    {
                                        Console.WriteLine("ANSWER 2 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[1]} POINTS!");
                                        team2Score[i] += nums[1];
                                        Console.WriteLine("TRY FOR MORE POINTS");

                                    }
                                    case (Answer1Guessed == false && StealChance = 4)
                                    {
                                        Console.WriteLine("ANSWER 3 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[2]} POINTS!");
                                        team2Score[i] += nums[2];
                                        Console.WriteLine("TRY FOR MORE POINTS");

                                    }
                                    case (Answer1Guessed == false && StealChance = 5)
                                    {
                                        Console.WriteLine("ANSWER 4 SELECTED");
                                        Console.WriteLine($"{team2[i]} GOT {nums[3]} POINTS!");
                                        team2Score[i] += nums[3];
                                        Console.WriteLine("TRY FOR MORE POINTS");
                                    }
                                    default:
                                    {
                                        Console.WriteLine("WRONG ANSWER");
                                        Console.WriteLine($"YOU HAVE {CpuGuesses} LEFT");
                                    }
                                    */
                                }

                            }
                            
                            break;
                        }
                        UserAnswer = Console.ReadLine();
                        UserAnswer.ToLower();
                        //Console.WriteLine(UserAnswer);
                        if ((UserAnswer.Contains(Answers[((i*4))%36])) && Answer1Guessed == false)
                        {
                            Console.WriteLine("ANSWER 1 SELECTED");
                            Console.WriteLine($"YOU GOT {nums[0]} POINTS!");
                            team1Score[i] += nums[0];
                            Console.WriteLine("TRY FOR MORE POINTS");
                            CorrectGuesses += 1;
                            Answer1Guessed = true;
                        }
                        else if (UserAnswer.Contains(Answers[((i*4)+1)%36]) && Answer2Guessed == false)
                        {
                            Console.WriteLine("ANSWER 2 SELECTED");
                            Console.WriteLine($"YOU GOT {nums[1]} POINTS!");
                            team1Score[i] += nums[1];
                            Console.WriteLine("TRY FOR MORE POINTS");
                            CorrectGuesses += 1;
                            Answer2Guessed = true;
                        }
                        else if ((UserAnswer.Contains(Answers[((i*4)+2)%36])) && Answer3Guessed == false)
                        {
                            Console.WriteLine("ANSWER 3 SELECTED");
                            Console.WriteLine($"YOU GOT {nums[2]} POINTS!");
                            team1Score[i] += nums[2];
                            Console.WriteLine("TRY FOR MORE POINTS");
                            CorrectGuesses += 1;
                            Answer3Guessed = true;
                        }
                        else if ((UserAnswer.Contains(Answers[((i*4)+3)%36])) && Answer4Guessed == false)
                        {
                            Console.WriteLine("ANSWER 4 SELECTED");
                            Console.WriteLine($"YOU GOT {nums[3]} POINTS!");
                            team1Score[i] += nums[3];
                            Console.WriteLine("TRY FOR MORE POINTS");
                            CorrectGuesses += 1;
                            Answer4Guessed = true;
                        }
                        else
                        {
                            Console.WriteLine("WRONG ANSWER");
                            Console.WriteLine($"YOU HAVE {UserGuesses-1} GUESSES LEFT");
                            UserGuesses -= 1;
                        }
                        
                        //Console.WriteLine(CorrectGuesses);
                        //Console.WriteLine(UserGuesses);

                    }
                    Console.WriteLine($"HERE ARE THE ANSWERS FOR QUESTION # {i+1}");
                    Console.WriteLine($"1. {Answers[((i*4))%36]} FOR {nums[0]} POINTS");
                    Console.WriteLine($"2. {Answers[((i*4)+1)%36]} FOR {nums[1]} POINTS");
                    Console.WriteLine($"3. {Answers[((i*4)+2)%36]} FOR {nums[2]} POINTS");
                    Console.WriteLine($"4. {Answers[((i*4)+3)%36]} FOR {nums[3]} POINTS");
                    Console.ReadLine();
                    Answer1Guessed = false;
                    Answer2Guessed = false;
                    Answer3Guessed = false;
                    Answer4Guessed = false;
                    
                    /*
                    switch (UserAnswer)
                    {
                    case (Answers[((i*4))%36]):
                        Console.WriteLine("ANSWER 1 SELECTED");
                        break;
                    case (Answers[((i*4)+1)%36]):
                        Console.WriteLine("ANSWER 2 SELECTED");
                        break;
                    case (Answers[((i*4)+2)%36]):
                        Console.WriteLine("ANSWER 3 SELECTED");
                        break;
                    case (Answers[((i*4)+3)%36]):
                        Console.WriteLine("ANSWER 4 SELECTED");
                        break;
                    default:
                        Console.WriteLine("WRONG ANSWER");
                        break;

                    }
                    */
                    


                    //Console.WriteLine(Answers[((i*4))%36]);
                    //Console.WriteLine(Answers[((i*4)+1)%36]);
                    //Console.WriteLine(Answers[((i*4)+2)%36]);
                    //Console.WriteLine(Answers[((i*4)+3)%36]);

                    //Console.WriteLine(question);
                    
                    
                    //Console.WriteLine(i);
                    i = i + 1;
                }
                //roundcount = rCount;
                //return roundcount;
                Console.WriteLine("AND THATS THE END LETS MOVE OVER TO THE TALLY BOARD AND LOOK AT THE SCORE");
                string tempscore = "";
                Console.WriteLine("TEAM 1:");
                for (int p = 0; p < 9; p++)
                {
                    tempscore = team1Score[p].ToString();
                    

                    Console.Write(team1[p].PadLeft(25));
                    Console.WriteLine(tempscore.PadLeft(5));

                    //Console.Write(Players[i].LName.PadLeft(20));
                    //Console.WriteLine(Players[i].Interest.PadLeft(30));
                    //Console.WriteLine(Convert.ToString(students[i].team).PadLeft(20));
                    //Console.WriteLine(i);
                }
                Console.WriteLine($"FOR A TOTAL SCORE OF {team1Score.Sum()}");
                Console.WriteLine("TEAM 2:");
                for (int p = 0; p < 9; p++)
                {
                    tempscore = team2Score[p].ToString();
                    Console.Write(team2[p].PadLeft(25));
                    Console.WriteLine(tempscore.PadLeft(5));
                }
                Console.WriteLine($"FOR A TOTAL SCORE OF {team2Score.Sum()}");

                Console.WriteLine("THIS MEANS LADIES AND GENTLEMEN");

                if (team1Score.Sum() > team2Score.Sum())
                {
                    Console.WriteLine("THAT TEAM 1 IS OUR WINNER TODAY!");
                    Console.WriteLine("AS A REWARD FOR WINNING THEY GET A NEW CAR");
                }
                if (team2Score.Sum() > team1Score.Sum())
                {
                    Console.WriteLine("THAT TEAM 2 IS OUR WINNER TODAY!");
                    Console.WriteLine("AS A REWARD FOR WINNING THEY GET A NEW CAR");
                }

                
                return team1Score;
                return team2Score;

                


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
                    //Console.WriteLine(team1[i]); 
                }
                for (int i = 0; i != 9; i++)
                {
                    team2[i] = Players[i+10].CombinedName;
                    //Console.WriteLine(team2[i]);
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
                    Console.WriteLine("THANKS FOR PLAYING");
                    Console.WriteLine("JOIN US SOON FOR ANOTHER GAME OF");
                    Console.WriteLine("FAMILY FEUD");
                    
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
