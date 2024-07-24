using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    // a class is a model, a design for an object
    // the card class has a property of data type string called Suit. you can get or set this property.
    public class Card
    {
        // Constructor method name is always the name of the class
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        
        // public data type name of property {object properties can only get and set}
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}

