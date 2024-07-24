using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    // Create a class
    class Test
    {
        static public firstMethod()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> numbersTwo = new List<int> { 7, 8, 9, 10 };
            // create three methods
            foreach (int num1 in numbers)
            {
                // pass each face through suits
                foreach (int num2 in numbersTwo)
                {
                    // each loop a new card is created a new card to have valued assigned
                    Card card = new Card();
                    // Add suit value
                    card.Suit = suit;
                    // add face value
                    card.Face = face;
                    // Add each face/suit to the Cards list
                    Cards.Add(card);
                }
            }


            // each of which will take one integer parameter in and return an integer.

            // The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.
        }
        
        
        
    }
}
