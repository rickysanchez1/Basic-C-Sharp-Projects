using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
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
            // Appending Cards dealt
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            // Access and display the first card in Deck and converts it to a string
            Console.WriteLine(card);
            // Log to path
            using (StreamWriter file = new StreamWriter(@"C:\Users\sinp3\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\twentyone\log.txt", true))
            {
                // DateTime.Now to return the datetime of this object.
                file.WriteLine(DateTime.Now);
                // Write this variable to path
                file.WriteLine(card);
            }
            // Access first card from the deck and remove it from deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
