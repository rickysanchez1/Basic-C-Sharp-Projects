using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate employee object
            Employee name = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call the SayName() method on the object
            name.SayName();


            Console.ReadLine();
        }
    }
}
