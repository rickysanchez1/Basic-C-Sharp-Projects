using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects
{
    public class Person
    {
        

        //List<string> fullname = new List<string>();


        // Method that takes no parameters and writes the persons full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
