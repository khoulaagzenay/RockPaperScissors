using System;

namespace Rock_Paper_Game
{
    public static class PlayerInput
    {
        static readonly string[] options = { "rock", "paper", "scissors" };
        public static string GetUserChoice()
        {
           
            while (true)
            {
                Console.WriteLine("\nEnter your choice (rock, paper, or scissors): ");
                string input = Console.ReadLine().ToLower();

                if (Array.Exists(options, option => option == input))
                    return input;

                Console.WriteLine("Invalid input. Please type rock, paper, or scissors. ");
            }
        }
        public static bool AskToPlayAgain()
        {
            while (true)
            {
                Console.Write("Do you want to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response == "y" || response == "yes")
                    return true;
                else if (response == "n" || response == "no")
                    return false;
                else
                    Console.WriteLine("Invalid input. Please type 'y' or 'n'.");
            }
        }

    }
}
