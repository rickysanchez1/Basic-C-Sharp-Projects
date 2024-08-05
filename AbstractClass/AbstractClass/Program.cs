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

            // Using polymorphism to create an object of type IQuittable.
            IQuittable quit = new Employee();
            
            // Calling the Quit() method
            quit.Quit();

            Console.ReadLine();
        }
    }
}
