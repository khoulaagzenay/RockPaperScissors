using System;

namespace Rock_Paper_Game
{
    public class Game
    {
        int wins = 0;
        int losses = 0;
        int draws = 0;
        bool keepPlaying = true;

        public void Start()
        {
            Console.WriteLine("Welcome to Rock Paper Game! 🎮 ");

            while (keepPlaying)
            {
                string userChoice = PlayerInput.GetUserChoice();
                string computerChoice = GameLogic.GetComputerChoice();
                Console.WriteLine($"Computer choice :  {computerChoice}");

                var result = GameLogic.DetermineWinner(userChoice, computerChoice);
                DisplayResult(result);
                keepPlaying = PlayerInput.AskToPlayAgain();
            }
            DisplayFinalResults();
        }

        public void DisplayResult(GameResult result)
        {
            switch (result)
            {
                case GameResult.Win:
                    Console.WriteLine("You win this round!");
                    wins++;
                    break;

                case GameResult.Lose:
                    Console.WriteLine("You lose this round");
                    losses++;
                    break;

                case GameResult.Draw:
                    Console.WriteLine("It's a draw");
                    draws++;
                    break;
            }
        }
        public void DisplayFinalResults()
        {
            Console.WriteLine("\nFinal results:");
            Console.WriteLine($"\nWins: {wins}, Losses: {losses}, Draws: {draws}");
            Console.WriteLine("\nThanks for playing!");
        }
        
    }
}
