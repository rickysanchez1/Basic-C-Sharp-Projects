using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    class Program
    {
        static void Main(string[] args)
        {
            //// creating game object
            //Game game = new TwentyOneGame();
            //// Creating new list 
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //// += Adding player
            //game += player;
            //// -= Removing player
            //game -= player;

            

            // Class Name, variable name = new to create a new instance of this method, method name
            Deck deck = new Deck();
            deck.Shuffle(3);

            // Loop through each card and display its face and suit
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
        }
    }

}
