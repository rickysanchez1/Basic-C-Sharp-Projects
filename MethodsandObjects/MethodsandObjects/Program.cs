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

            // Created new list for method to loop and display
            fullName.FirstName = new List<string>() { "Sample" };
            fullName.LastName = new List<string>() { "Student"};
            // Calling superclass method SayName through the Employee class
            fullName.SayName();

            

            Console.ReadLine();

        }
    }
}
