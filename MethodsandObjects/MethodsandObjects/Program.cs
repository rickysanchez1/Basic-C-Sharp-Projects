using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fullName = new Employee();

            //  Calling method
            fullName.FirstName = "Sample";
            fullName.LastName = "Student";
            // Calling superclass method SayName through the Employee class
            fullName.SayName();

            

            Console.ReadLine();

        }
    }
}
