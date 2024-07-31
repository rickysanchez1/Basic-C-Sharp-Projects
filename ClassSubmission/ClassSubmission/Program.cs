using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideInt number = new DivideInt();

            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            // calling method to divide user inputs number by 2
            number.outputInt(num);

            // Display the values that were output by method
            int a, b;
            OutputVariable.outputValue(out a, out b);

            // Passing values to overloaded method
            number.outputInt(num, 500);

            Console.ReadLine();
        }
    }
}
