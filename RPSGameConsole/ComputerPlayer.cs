using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RPSGameConsole
{
    class ComputerPlayer : IPlayer
    {
        private string lastChoice = "";
        public string Play(IGame game, string playerName)
        {
            if (string.IsNullOrEmpty(lastChoice))
            {
                //select random
                var options = game.GetGameChoices();
                var random = new Random();
                var choice = options.ElementAt(random.Next(0, options.Count()));
                //memorise previous choices
                lastChoice = choice;
                return choice;
            }
            else 
            {
                //select option that beats its previous choice
                var choice = game.GetOptionForWin(lastChoice);
                lastChoice = choice;
                return choice;
            }
            
        }

     
    }
}
