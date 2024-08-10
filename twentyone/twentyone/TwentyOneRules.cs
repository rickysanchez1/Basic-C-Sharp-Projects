using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    class TwentyOneRules
    {
        // Naming convention in private classes is _ ahead of the name.
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            // creating int for each Ace in the deck. to create a method for all possible hand values
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            // Creating array with amount of aces in deck + 1
            int[] result = new int[aceCount + 1];
            // creating variable to check 
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value += value + (i * 10);
                result[i] = value;
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        public static bool ShoulderDealerStay(List<Card> Hand)
        {

        }
    }
}
