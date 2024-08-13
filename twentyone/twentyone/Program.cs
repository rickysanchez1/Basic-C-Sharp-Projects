using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace twentyone
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome new player 
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            // create var for new player
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            // {0} is a variable placeholder for playerName
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            // if player is actively playing
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // Create new player using constructor in player class to set the properties
                Player player = new Player(playerName, bank);
                // create new instance of twentyonegame
                Game game = new TwentyOneGame();
                // Add current player to twentyonegame
                game += player;
                // player is currently playing
                player.isActivelyPlaying = true;
                // while player is actively playing, play game
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");

            

            

           
          

            Console.ReadLine();
        }
    }

}
