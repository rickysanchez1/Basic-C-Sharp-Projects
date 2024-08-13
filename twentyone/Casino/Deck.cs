using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        // Constuctor
        public Deck()
        {
            Cards = new List<Card>();

           for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
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
