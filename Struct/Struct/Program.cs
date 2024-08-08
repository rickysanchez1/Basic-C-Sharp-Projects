using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of data type Number and assign a value
            Number number = new Number { Amount = 59 };
            
            // Print number and the value that was set through Amount
            Console.WriteLine(number.Amount);
            Console.ReadLine();

            

        }
        
    }
}
