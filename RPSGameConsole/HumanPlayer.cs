using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace RPSGameConsole
{
    class HumanPlayer : IPlayer
    {
        public string Play(IGame game, string playerName)
        {
            Console.Write(string.Format("{0}: ", playerName));
            var choice = Console.ReadLine();
            var options = game.GetGameChoices();
            int index = -1;
            string selectedOption = "";
            while (index < 0)
            {
                try
                {
                    index = int.Parse(choice);
                    selectedOption = options.ElementAt(index-1);
                }
                catch
                {

                    Console.WriteLine(string.Format("Please Enter a valid number between {0} and {1}", 1, options.Count()));
                    //this is in case player enter a number out of option range, to make sure the loop continues
                    index = -1;
                    choice = Console.ReadLine();
                }
            }
            return selectedOption;
        }

    }
}
