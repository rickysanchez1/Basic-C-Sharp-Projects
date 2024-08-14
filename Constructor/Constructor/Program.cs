using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating const var
            const string person = "person";
            var money = 100;

            MyClass myClass = new MyClass(person);


            Console.ReadLine();
        }
    }
}
