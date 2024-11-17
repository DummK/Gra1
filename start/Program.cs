using System;


namespace start 
{ 
    class Game
    {
        private int playerChoice;
        private int computerChoice;

        public void PlayerChoosing()
        {
            Console.Write("Papier(1), kamień(2) czy nożyce(3): ");
            playerChoice = Convert.ToInt32(Console.ReadLine());
                while(true)
                {
                    if(playerChoice < 1 || playerChoice > 3)
                    {
                        Console.Write("Spróbuj ponownie: ");
                        playerChoice = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
        }
        public void ComputerChoosing(Random r)
        {
            computerChoice = r.Next(1, 4);
        }
        public void CheckForWinner()
        {
            Console.Write("Wybór komputera: ");
                if (computerChoice == 1)
                {
                    Console.WriteLine("papier");
                }
                else if (computerChoice == 2)
                {
                    Console.WriteLine("kamień");
                }
                else
                {
                    Console.WriteLine("nożyce");
                }

            switch(playerChoice)
            {
                case 1:
                    if(computerChoice == 1)
                    {
                        Console.WriteLine("Remis");
                    }
                    else if(computerChoice == 2)
                    {
                        Console.WriteLine("Wygrywasz");
                    }
                    else
                    {
                        Console.WriteLine("Komputer Wygrywa");
                    }
                    break;
                case 2:
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("Komputer Wygrywa");
                    }
                    else if (computerChoice == 2)
                    {
                        Console.WriteLine("Remis");
                    }
                    else
                    {
                        Console.WriteLine("Wygrywasz");
                    }
                    break;
                case 3:
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("Wygrywasz");
                    }
                    else if (computerChoice == 2)
                    {
                        Console.WriteLine("Komputer Wygrywa");
                    }
                    else
                    {
                        Console.WriteLine("Remis");
                    }
                    break;
            }
        }

        public void StartGame()
        {
            Random random = new();
            String playAgain;
            
            Console.WriteLine("----Gra----");
            while (true)
            {
                ComputerChoosing(random);
                PlayerChoosing();
                CheckForWinner();
                    Console.Write("Jeszcze raz (tak/nie):  ");
                    playAgain = Console.ReadLine().ToLower();
                        while(true)
                        {
                            if (playAgain == "tak" || playAgain == "nie")
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Spróbuj ponownie: ");
                                playAgain = Console.ReadLine().ToLower();
                            }
                        }

                if (playAgain == "nie")
                {
                    break;
                }
            }
            Console.WriteLine("-----------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new();

            game.StartGame();
        }
    }
}
