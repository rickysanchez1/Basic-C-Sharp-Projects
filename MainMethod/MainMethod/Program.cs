using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating class method
            MathOperation number = new MathOperation();

            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            // Calling method and passing user input as a parameter
            int result = number.returnInt(num);
            // Display result as an integer

            Console.WriteLine("Your number + 50 = " + result);

            // Asking user to enter a number with a decimal
            Console.WriteLine("Enter a number with a decimal.");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            int resultDecimal = number.returnInt(num2);
            // Display result as an integer
            Console.WriteLine("Your decimal number multiplied by 10, rounded up = " + resultDecimal);

            // Asking user to enter a number
            Console.WriteLine("Please enter in another number.");
            string stringNumber = Console.ReadLine();
            int resultString = number.returnInt(stringNumber);
            // Display result as an integer
            Console.WriteLine("Your number divided by = 20" + resultString);

            Console.ReadLine();
        }
    }
}
