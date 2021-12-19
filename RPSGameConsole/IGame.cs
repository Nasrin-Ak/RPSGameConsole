using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGameConsole
{
    public interface IGame
    {
        IEnumerable<string> GetGameChoices();
        GameResult DefineResult(string choice1, string choice2);
        void DisplayGameOptionsAndRules();
        void DisplayGameMenu();
        string GetOptionForWin(string opponentChoice);

    }

    public enum GameResult { Win, Lose, Tie };
}
