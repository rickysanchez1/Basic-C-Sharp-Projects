using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number
            Console.WriteLine("What number would you like to do the math operations on?");
            // Convert input in to int
            int num1 = Convert.ToInt32(Console.ReadLine());
            

            // instantiating class method
            ReturnInteger num = new ReturnInteger();

            // Calling method and passing user input as a parameter
            int result = num.returnInt(num1);
            int result2 = num.returnInt2(num1);
            int result3 = num.returnInt3(num1);

            Console.WriteLine("Your number multipled by 15 = " + result);
            Console.WriteLine("Your number plus 5 = " + result2);
            Console.WriteLine("Your number minus 3 = " + result3);
            Console.ReadLine();

            


        }
    }
}
