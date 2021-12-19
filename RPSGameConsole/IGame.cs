using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGameConsole
{
    public interface IGame
    {
        /// <summary>
        /// returns options that could be available for the game
        /// example:Rock paper scissors
        /// </summary>
        IEnumerable<string> GetGameChoices();

        /// <summary>
        /// returns result (win, lose, tie) for player 1 based on choices of two players
        /// </summary>
        GameResult DefineResult(string choice1, string choice2);

        /// <summary>
        /// display summary of game rules in console
        /// </summary>
        void DisplayGameOptionsAndRules();

        /// <summary>
        /// display available options for user to chose from 
        /// example : 1- rock 2-paper 3-scissors
        /// </summary>
        void DisplayGameMenu();

        /// <summary>
        /// find the option that could beats currentChoice
        /// this could be used by computer player to select next move
        /// </summary>
        string GetOptionForWin(string currentChoice);

    }

    public enum GameResult { Win, Lose, Tie };
}
