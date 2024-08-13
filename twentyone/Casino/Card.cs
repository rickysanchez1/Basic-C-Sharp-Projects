using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    // a class is a model, a design for an object
    // the card class has a property of data type string called Suit. you can get or set this property.
    public struct Card
    {        
        // public data type name of property {object properties can only get and set}
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public override string ToString()
        {
            // Custom toString method to display the values of each card.
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}

