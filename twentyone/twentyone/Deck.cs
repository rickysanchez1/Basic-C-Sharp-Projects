using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    public class Deck
    {
        // Constuctor
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
        // Property
        public List<Card> Cards { get; set; }

        // takes a list of cards and returns a shuffled deck of cards. Out sends value to variable timesShuffled
        public void Shuffle(int times = 1)
        {
            // Adding variable to count how many times loops ran
            for (int i = 0; i < times; i++)
            {
                // Increment timesShuffled by 1
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }

}
