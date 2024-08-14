using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    public class MyClass
    {
        // Chaining constructor to provide default value is none is given
        public MyClass(string name) : this(name, 500)
        {

        }
        public MyClass(string name, int money)
        {
            Console.WriteLine(name + money);
        }
    }
}
