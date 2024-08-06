using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiating 2 objects with values to their properties
            Employee name1 = new Employee { 
                Id = 1, 
                FirstName = "Jane", 
                LastName = "Jones" 
            };
            Employee name2 = new Employee { 
                Id = 1, 
                FirstName = "John", 
                LastName = "Smith" 
            };
            // Then compare the two Employee objects using the newly overloaded operators and display the results.

            
            bool sameId = name1.Id == name2.Id;
            bool notSameId = name1.Id != name2.Id;


            Console.WriteLine(sameId);
            Console.WriteLine(notSameId);
            Console.ReadLine();
        }
    }
}
