using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    // Created generic type parameter
    public class Employee<T> 
    {
        // Generic list named things
        public List<T> things { get; set; }

        // Using method to create a new list for things
        public Employee()
        {
            things = new List<T>();
        }
    }
}
