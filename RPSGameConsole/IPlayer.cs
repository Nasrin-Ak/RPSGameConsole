using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGameConsole
{
    public interface IPlayer
    {
        /// <summary>
        /// choose a valid option from the game 
        /// </summary>
        public string Play(IGame game, string playerName);
    }
}
