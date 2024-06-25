using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter in the weight of the package");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package height.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package length");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int packageDimension = packageWidth + packageHeight + packageLength;
                int packageQuote = packageWidth * packageHeight * packageLength * packageWeight / 100;
                string packageDollar = packageQuote.ToString("C");
                if (packageDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine(packageDollar + " Is the cost to mail youre package.");
                }
            }


            Console.ReadLine();
        }
    }
}
