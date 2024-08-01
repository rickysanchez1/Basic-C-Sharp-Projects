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
            //List<Game> games = new List<Game>();

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();

            // Class Name, variable name = new to create a new instance of this method, method name
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //// Loop through each card and display its face and suit
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);

            //Console.ReadLine();
        }
    }

}
