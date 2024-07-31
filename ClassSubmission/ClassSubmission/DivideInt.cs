using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
     class DivideInt
     {
        // void method that outputs an integer
        public void outputInt(int a)
        {
            int divide = a / 2;
            Console.WriteLine("Your number divided by 2 = " + divide);
        }

        // Overloaded method that will take in 2 parameters
        public void outputInt(int a, int b)
        {
            int sum = a + b;
        }

     }
}
