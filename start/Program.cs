using System;


namespace start

    class Game
    {
        private String playerChoice;
        private String computerChoice;

        public void PlayerChoosing()
        {
            Console.WriteLine("Papier, kamień czy nożyce");
            playerChoice = Console.ReadLine().ToLower();
        }

        public void StartGame()
        {
            Console.WriteLine("----Game----");
            while (true)
            {
                PlayerChoosing();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
