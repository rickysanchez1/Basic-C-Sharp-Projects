using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
        public class Deck
        {
            public Deck()
            {
                Cards = new List<Card>();

                // for each face of 13 cards
                List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
                List<string> Faces = new List<string>()
                {
                    "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                    "Jack", "Queen", "King", "Ace"
                };
                // foreach item in Faces 
                foreach (string face in Faces)
                {
                    // pass each face through suits
                    foreach (string suit in Suits)
                    {
                        // each loop a new card is created a new card to have values assigned
                        Card card = new Card();
                        // Add suit value
                        card.Suit = suit;
                        // add face value
                        card.Face = face;
                        // Add each face/suit to the Cards list
                        Cards.Add(card);
                    }
                }
            }
        public List<Card> Cards { get; set; }
        }
        
}
