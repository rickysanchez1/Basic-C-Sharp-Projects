using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        // takes a list of cards into hand
        public void Deal(List<Card> Hand)
        {
            // Take the first card from the deck and add it to hand.
            Hand.Add(Deck.Cards.First());
            // Access and display the first card in Deck and converts it to a string
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            // Access first card from the deck and remove it from deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
