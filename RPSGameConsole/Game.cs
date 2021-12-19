using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGameConsole
{
    public class Game : IGame
    {
        public IEnumerable<string> GetGameChoices()
        {
            return new string[] { "Rock", "Paper", "Scissors" };
        }

        public GameResult DefineResult(string choice1, string choice2)
        {
            if (choice1 == choice2)
            {
                return GameResult.Tie;
            }
            if (choice1 == "Rock" && choice2 == "Paper")
            {
                return GameResult.Lose;
            }
            if (choice1 == "Rock" && choice2 == "Scissors")
            {
                return GameResult.Win;
            }
            if (choice1 == "Paper" && choice2 == "Rock")
            {
                return GameResult.Win;
            }
            if (choice1 == "Paper" && choice2 == "Scissors")
            {
                return GameResult.Lose;
            }
            if (choice1 == "Scissors" && choice2 == "Rock")
            {
                return GameResult.Lose;
            }
            if (choice1 == "Scissors" && choice2 == "Paper")
            {
                return GameResult.Win;
            }
            else return GameResult.Tie;
        }

        public void DisplayGameOptionsAndRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors game");
            Console.WriteLine("--------------------Game Rules------------------");
            Console.WriteLine("Rock beats scissors");
            Console.WriteLine("Paper beats rock");
            Console.WriteLine("Scissors beats paper");
            Console.WriteLine("------------------------------------------------");
        }

        public void DisplayGameMenu()
        {
            Console.WriteLine("Please choose your option by entering the number:");
            int optionNumber = 1;
            foreach (var item in GetGameChoices())
            {
                Console.WriteLine(string.Format("{0} - {1}", optionNumber, item));
                optionNumber++;
            }

        }

        public string GetOptionForWin(string currentChoice)
        {
            switch (currentChoice)
            {
                case "Rock":
                    return "Paper";
                case "Paper":
                    return "Scissors";
                case "Scissors":
                    return "Rock";
                default:
                    return "";
            }
        }

    }
}
