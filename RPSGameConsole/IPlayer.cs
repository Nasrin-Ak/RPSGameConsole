using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGameConsole
{
    public interface IPlayer
    {
        public string Play(IGame game, string playerName);
    }
}
