using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation number = new MathOperation();

            Console.WriteLine("Enter number.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number or just press enter.");
            string input = Console.ReadLine();

            int num2;
            // if a value was received then tryparse will convert to an int and output value as num2 variable
            if (int.TryParse(input, out num2))
            {
                // Pass both inputs as parameters to method
                int result2 = number.sum(num, num2);
                Console.WriteLine(result2);
            }
            // if no value was received then the single parameter will be passed
            else
            {
                int result = number.sum(num);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
