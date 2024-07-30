using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MathOperation
    {
        // Method that will take in an integer
        public int returnInt(int number)
        {
            // Create a Math operation with an int parameter
            int returnValue = number + 50;
            // return integer
            return returnValue;
        }

        public int returnInt(decimal number)
        {
            // convert decimal to int and multiplied by 10
            int returnValue = decimal.ToInt32(number) * 10;

            return returnValue;
        }
        public int returnInt(string number)
        {
            // Convert int to string
            int returnValue = Int32.Parse(number) / 5;
            // return string as an int
            return returnValue;
        }


    }
}
