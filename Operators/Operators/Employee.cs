using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
     class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloaded method comparison with Employee class and Id property
        public static bool operator ==(Employee name1, Employee name2)
        {
            return name1.Id == name2.Id;
        }

        public static bool operator !=(Employee name1, Employee name2)
        {
            return !(name1.Id == name2.Id);
        }
    }
}
