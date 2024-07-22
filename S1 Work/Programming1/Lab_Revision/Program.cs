// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Step 1 Age verification
Step 2 Boot if under 18
Step 3 Ask how many rounds
Step 4 Set base money
Step 5 Roll 1-13 
Step 6 Check if result is 1: Money +20
Step 7 Check if result is 11,12,13: Money +10
Step 8 else Money -CardValue
Step 9 Show card
Step 10 Display total
Step 11 restart option (No age verification)
*/

Random rand = new Random();
int PlayerAge = 0;
int AgeBarrier = 17;
int PlayerBalance = 0;
int RoundCount = 0;
int CurrentRound = 0;
int CurrentCard = 0;
string PlayerResponse;
//CLYDE CASINO BORING VERSION
Console.WriteLine("WELCOME TO CLYDE'S CASINO");
Console.WriteLine("BEFORE WE BEGIN HOW OLD ARE YOU?");
PlayerAge = Convert.ToInt32(Console.ReadLine());
if (PlayerAge > AgeBarrier)
{
    Console.WriteLine("WONDERFUL ENJOY YOUR STAY");
    GameStart();
    void GameStart()
    {
    
        
        Console.WriteLine("YOU HAVE AN APPOINTMENT FOR A 5 ROUND MATCH?");
        //RoundCount = Convert.ToInt32(Console.ReadLine());
        RoundCount = 5;
        Console.WriteLine($"YOU WANT TO PLAY {RoundCount} ROUNDS?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        PlayerResponse = Console.ReadLine();
        PlayerResponse.ToLower();
        if (PlayerResponse.Equals("1") || PlayerResponse.Equals("yes") || PlayerResponse.Equals("y"))
        {
            Console.WriteLine("MAGNIFICENT LET THE GAMES BEGIN.");
            while (CurrentRound < RoundCount)
            {
                CurrentRound++;
                Console.WriteLine($"WELCOME TO ROUND {CurrentRound}!");
                Console.WriteLine($"YOU HAVE {PlayerBalance}$");
                Console.WriteLine("PRESS ANY KEY TO DEAL");
                Console.ReadLine();
                //Console.WriteLine("WOULD YOU LIKE TO HIT OR CASH OUT?");
                //Console.WriteLine("1. Hit Me");
                //Console.WriteLine("2. Cash Out Please");
                //PlayerResponse = Console.ReadLine();
                //PlayerResponse.ToLower();
                //if (PlayerResponse.Equals("1") || PlayerResponse.Equals("yes") || PlayerResponse.Equals("y"))
                //{
                    Console.WriteLine("LETS SEE WHAT YOU GOT");
                    Thread.Sleep(500);
                    CurrentCard = rand.Next(1,13);
                    switch (CurrentCard)
                    {
                        case(1):
                            Console.WriteLine("NICE ACE");
                            Console.WriteLine("YOU GOT 20$");
                            PlayerBalance = (PlayerBalance + 20);
                            break;
                        case(11):
                            Console.WriteLine("NICE JACK");
                            Console.WriteLine("YOU GOT 10$");
                            PlayerBalance = (PlayerBalance + 10);
                            break;
                        case(12):
                            Console.WriteLine("NICE QUEEN");
                            Console.WriteLine("YOU GOT 10$");
                            PlayerBalance = (PlayerBalance + 10);
                            break;
                        case(13):
                            Console.WriteLine("NICE KING");
                            Console.WriteLine("YOU GOT 10$");
                            PlayerBalance = (PlayerBalance + 10);
                            break;
                        default:
                            Console.WriteLine("BAD LUCK");
                            Console.WriteLine($"YOU GOT A {CurrentCard}");
                            Console.WriteLine($"YOU LOST {CurrentCard}$");
                            PlayerBalance = (PlayerBalance - CurrentCard);
                            break;
                    }
                //}
                /*else
                {
                    if (CurrentRound < RoundCount/2)
                    {
                        Console.WriteLine("QUITTING SO SOON?");
                        goto GameEnd;
                    }
                    else
                    {
                        Console.WriteLine("PLAYING IT SAFE");
                        Console.WriteLine("GOOD CHOICE!");
                        goto GameEnd;
                    }
                }*/
            }
            Console.WriteLine("AND FINISH!");
            Console.WriteLine($"YOU HAVE EARNED {PlayerBalance}$");
            Console.WriteLine("WANT TO PLAY AGAIN?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            PlayerResponse = Console.ReadLine();
            if (PlayerResponse.Equals("1") || PlayerResponse.Equals("yes") || PlayerResponse.Equals("y"))
                {
                    CurrentRound = 0;
                    GameStart();
                }
            else
            {
                GameEnd();
            }



        }
        else 
        {
            Console.WriteLine("NO?");
            GameEnd();
        }
    }
        
        

    
}

else
{
    Console.WriteLine($"COME BACK IN {AgeBarrier - PlayerAge + 1} YEARS KID");
    FIN();
}
void GameEnd()
{
    
    Console.WriteLine("THANKS FOR COMING TO CLYDE'S CASINO");
    Console.WriteLine("HOPE YOU ENJOYED YOUR STAY COME AGAIN SOON!");
    if (PlayerBalance > 0)
    {
        Console.WriteLine($"HERE IS YOUR WELL EARNED {PlayerBalance} DOLLARS");
    }
    if (PlayerBalance < 0)
    {
        Console.WriteLine($"REMEMBER TO PAY US BACK THE {PlayerBalance} DOLLARS YOU OWE US!");
    }
    else
    {
        FIN();
    }
}

    FIN();
static void FIN()
{
    Console.ReadLine();
}
/*
//CLYDE'S CASINO GOOD EDITION
Console.WriteLine("WELCOME TO CLYDE'S CASINO");
Console.WriteLine("BEFORE WE BEGIN HOW OLD ARE YOU?");
PlayerAge = Convert.ToInt32(Console.ReadLine());
if (PlayerAge > AgeBarrier)
{
    Console.WriteLine("WONDERFUL ENJOY YOUR STAY");
    GameStart:
        
        Console.WriteLine("HOW MANY ROUNDS WOULD YOU LIKE TO PLAY?");
        RoundCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"SO YOU WANT TO PLAY {RoundCount} ROUNDS?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        PlayerResponse = Console.ReadLine();
        PlayerResponse.ToLower();
        if (PlayerResponse.Equals("1") || PlayerResponse.Equals("yes") || PlayerResponse.Equals("y"))
        {
            Console.WriteLine("MAGNIFICENT LET THE GAMES BEGIN.");
            while (CurrentRound < RoundCount)
            {
                CurrentRound++;
                Console.WriteLine($"WELCOME TO ROUND {CurrentRound}!");
                Console.WriteLine($"YOU HAVE {PlayerBalance}$");
                Console.WriteLine("WOULD YOU LIKE TO HIT OR CASH OUT?");
                Console.WriteLine("1. Hit Me");
                Console.WriteLine("2. Cash Out Please");
                PlayerResponse = Console.ReadLine();
                PlayerResponse.ToLower();
                if (PlayerResponse.Equals("1") || PlayerResponse.Equals("yes") || PlayerResponse.Equals("y"))
                {
                    Console.WriteLine("LETS SEE WHAT YOU GOT");
                    CurrentCard = rand.Next(1,13);
                    switch (CurrentCard)
                    {
                        case(1):
                            Console.WriteLine("NICE ACE");
                            Console.WriteLine("YOU GOT 20$");
                            PlayerBalance = (PlayerBalance + 20);
                            break;
                        case(11):
                            Console.WriteLine("NICE JACK");
                            Console.WriteLine("YOU GOT 10$");
                            PlayerBalance = (PlayerBalance + 10);
                            break;
                        case(12):
                            Console.WriteLine("NICE QUEEN");
                            Console.WriteLine("YOU GOT 10$");
                            PlayerBalance = (PlayerBalance + 10);
                            break;
                        case(13):
                            Console.WriteLine("NICE KING");
                            Console.WriteLine("YOU GOT 10$");
                            PlayerBalance = (PlayerBalance + 10);
                            break;
                        default:
                            Console.WriteLine("BAD LUCK");
                            Console.WriteLine($"YOU GOT A {CurrentCard}")
                            Console.WriteLine($"YOU LOST {CurrentCard}$");
                            PlayerBalance = (PlayerBalance - CurrentCard);
                            break;
                    }
                }
                else
                {
                    if (CurrentRound < RoundCount/2)
                    {
                        Console.WriteLine("QUITTING SO SOON?");
                        goto GameEnd;
                    }
                    else
                    {
                        Console.WriteLine("PLAYING IT SAFE");
                        Console.WriteLine("GOOD CHOICE!");
                        goto GameEnd;
                    }
                }
            }
            Console.WriteLine("AND FINISH!");
            Console.WriteLine($"YOU HAVE EARNED {PlayerBalance}");
            Console.WriteLine("WANT TO PLAY AGAIN?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            PlayerResponse = Console.ReadLine();
            if (PlayerResponse.Equals("1") || PlayerResponse.Equals("yes") || PlayerResponse.Equals("y"))
                {
                    goto GameStart;
                }
            else
            {
                goto GameEnd;
            }



        }
        else 
        {
            Console.WriteLine("NO?");
            goto GameStart;
        }
        
        

    
}

else
{
    Console.WriteLine($"COME BACK IN {AgeBarrier - PlayerAge + 1} YEARS KID");
    goto FIN;
}
    GameEnd:
    Console.WriteLine("THANKS FOR COMING TO CLYDE'S CASINO");
    Console.WriteLine("HOPE YOU ENJOYED YOUR STAY COME AGAIN SOON!");
    if (PlayerBalance > 0)
    {
        Console.WriteLine($"HERE IS YOUR WELL EARNED {PlayerBalance} DOLLARS");
    }
    else
    {
        Console.WriteLine($"REMEMBER TO PAY US BACK THE {PlayerBalance} DOLLARS YOU OWE US!");
    }

    goto FIN;
    FIN:
    Console.ReadLine();
*/