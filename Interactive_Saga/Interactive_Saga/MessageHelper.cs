using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class MessageHelper
    {
        /// <summary>
        /// Welcomes the user.
        /// </summary>
        public void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("WELCOME MESSAGE TO THE USER");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Mainmenu message.
        /// </summary>
        public void MainMenuMessage()
        {
            Console.WriteLine("Main Menu");
            Console.ReadLine();
            Console.WriteLine("1) Go out on adventure!");
            Console.WriteLine("2) Show Stats");
            Console.WriteLine("3) Show Rules of Game");
            Console.WriteLine("4) Exit Game");
        }

        /// <summary>
        /// Ruleses the of game.
        /// </summary>
        public void RulesOfGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("RULES OF THE GAME");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Error message for the menu.
        /// </summary>
        public void MenuErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a number between 1-4 to chose an alternative from the menu.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
