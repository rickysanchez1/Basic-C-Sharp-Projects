using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino
{
    public class FraudException : Exception
    {
        // Creating specific exception
        public FraudException()
            // Inherit from the base constructor, Exception
            : base() { }
        // Overloading the constructor method
        public FraudException(string message) 
            : base(message) { }
    }
}
