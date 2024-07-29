using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class ReturnInteger
    {
        // First method will take user input and multiply by 15
        public int returnInt(int number)
        {
            int returnValue = number * 15;

            return returnValue;
        }
        // Second method will take user input and add 5
        public int returnInt2(int number)
        {
            int returnValue = number + 5;
            return returnValue;
        }
        // Third method will take user input and subtract by 3
        public int returnInt3(int number)
        {
            int returnValue = number - 3;
            return returnValue;
        }
    }
}
