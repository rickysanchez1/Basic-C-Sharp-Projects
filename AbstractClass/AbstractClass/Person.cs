using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        // 2 properties, firstName and lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Method
        public virtual void SayName()
        {

        }
    }
}
