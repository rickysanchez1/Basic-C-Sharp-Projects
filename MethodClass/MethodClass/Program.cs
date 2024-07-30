using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating class method
            MathOperation number = new MathOperation();

            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calling method and passing two values
            number.twoIntegers(5, 10);

            // Calling method passing 2 variables
            number.twoIntegers(num, num2);

            Console.ReadLine();

        }
    }
}
