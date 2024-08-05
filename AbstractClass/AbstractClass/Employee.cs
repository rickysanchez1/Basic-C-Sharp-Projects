using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Inherit from Person class and inherit from interface IQuittable
     public class Employee : Person, IQuittable
    {
        // Implementing method from Person class
        public override void SayName()
        {

        }

        //
        public void Quit()
        {
            Console.WriteLine("Quitting time.");
        }

        
    }
}
