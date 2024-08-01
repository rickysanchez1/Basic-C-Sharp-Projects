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
            // Go through each parameter from FirstName
            foreach (string fname in FirstName)
            {
                // Go through each parameter from LastName
                foreach (string lname in LastName)
                {
                    // Display names
                    Console.WriteLine("Name: " + fname + lname);
                }
            }

        }

        public List<string> FirstName  { get; set; }
        public List<string> LastName  { get; set; }
    }
}
