using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Game
{
    public static class GameLogic
    {
        private static readonly string[] options = { "rock", "paper", "scissors" };
        private static readonly Random rand = new Random();

        public static string GetComputerChoice()
        {
            return options[rand.Next(options.Length)];
        }

        public static GameResult DetermineWinner(string user, string computer)
        {
            if (user == computer)
                return GameResult.Draw;

            if (user == "rock" && computer == "scissors" ||
                user == "paper" && computer == "rock" ||
                user == "scissors" && computer == "paper")
                return GameResult.Win;
            else
                return GameResult.Lose;
        }
    }
    public enum GameResult
    {
        Win,
        Lose,
        Draw
    }
}
