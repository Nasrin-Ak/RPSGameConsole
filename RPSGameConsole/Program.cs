using System;
using System.Collections.Generic;

namespace RPSGameConsole
{
    class Program
    {
        public static int player1_Wins = 0;
        public static int player2_Wins = 0;
        static void Main(string[] args)
        {
            var exitPlay = "";
            while(exitPlay.ToUpper() != "EXIT")
            {
                playGame();
                Console.WriteLine("to leave the game type EXIT, to play again press enter");
                exitPlay = Console.ReadLine();
            }
        }

        public static void playGame()
        {
            IPlayer player1;
            IPlayer player2;
            player1_Wins = 0;
            player2_Wins = 0;

            IGame game = new Game();
            game.DisplayGameOptionsAndRules();

            Console.WriteLine("Please enter number of player(s), 1 or 2?");
            var playerCount = Console.ReadLine().Trim();
            //validate number of players input
            while (playerCount != "1" && playerCount != "2")
            {
                Console.WriteLine("Please enter a valid number of player, 1 or 2?");
                playerCount = Console.ReadLine().Trim();
            }
            //we have at least one human player
            player1 = new HumanPlayer();
            if (playerCount == "1")
            {
                player2 = new ComputerPlayer();
            }
            else
            {
                player2 = new HumanPlayer();
            }

            //The first player to win 3 rounds wins and finish the game
            while (player1_Wins < 3 && player2_Wins < 3)
            {
                //play Game
                game.DisplayGameMenu();
                var choice1 = player1.Play(game, "player1");
                var choice2 = player2.Play(game, "player2");
                var result = game.DefineResult(choice1, choice2);
                switch (result)
                {
                    case GameResult.Win:
                        player1_Wins++;
                        DisplayResults(choice1, choice2, result);
                        break;
                    case GameResult.Lose:
                        player2_Wins++;
                        DisplayResults(choice1, choice2, result);
                        break;
                    case GameResult.Tie:
                        //resetart session
                        player1_Wins = 0;
                        player2_Wins = 0;
                        DisplayResults(choice1, choice2, result);
                        break;
                    default:
                        break;
                }
            }
            //define winner
            if (player1_Wins == 3)
            {
                Console.WriteLine("Congrats! Player1 is winner of this game ");
            }
            else
                Console.WriteLine("Congrats! Player2 is winner of this game ");
        }
        
        /// <summary>
        /// show The players choice and scores after each round of play
        /// </summary>
        public static void DisplayResults(string choice1, string choice2, GameResult result)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(string.Format("player1: {0} , Player2: {1} ", choice1, choice2));
            if (result== GameResult.Tie)
            {
                Console.WriteLine("Tie! session restart, Scores:  Player1: 0 , player2: 0");
            }
            else
            {
                Console.WriteLine(string.Format("Scores:  Player1: {0} , player2: {1}", player1_Wins, player2_Wins));
            }
            
            Console.WriteLine("---------------------------------------------------------");
        }



    }
}
