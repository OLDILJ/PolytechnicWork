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
            //vector<string> FamFeudPlayers;
            int StartedGame = 0;
            string PlayerChoice;
            Console.WriteLine("Welcome To Family Feud");
            Console.WriteLine("Before We Begin Please Type {Y} To Take Part In This Game");
            PlayerChoice = Console.ReadLine();
            switch(PlayerChoice)
            {
                case "y" or "Y":
                    Console.WriteLine("WELCOME");
                    Console.WriteLine("Do You Want To Manually Define Your Players?");
                    PlayerChoice = Console.ReadLine();
                    switch(PlayerChoice)
                    {
                        case "y" or "Y":
                        PlayerDefining();
                        break;
                        default:
                        TextReader();
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
                FamFeudPlayers[] Players = new FamFeudPlayers[5];
    
                for (int i = 0; i < Players.Length; i++)
                {
                    Console.WriteLine("MaorPeople");
                }

            }
            void TextReader()
            {
                string[] lines = File.ReadAllLines(textFile);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
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