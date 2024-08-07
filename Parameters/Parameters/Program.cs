using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {


            // Instantiating stringList object
            Employee<string> stringList = new Employee<string>();
            // Adding values through string and creating new list
            stringList.things.AddRange(new List<string> { "Fred", "Joe", "Bill" });

            // Loop through each name and print to console.
            foreach (var thing in stringList.things)
            {
                Console.WriteLine(thing);
            }

            // Instantiating intList
            Employee<int> intList = new Employee<int>();
            // Assigning int values to intList
            intList.things.AddRange(new List<int> { 1, 2, 3 });
            
            foreach (var thing in intList.things)
            {
                Console.WriteLine(thing);
            }



            Console.ReadLine();

        }
    }
}
