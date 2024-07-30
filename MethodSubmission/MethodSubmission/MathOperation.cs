using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class MathOperation
    {
     
        // 2 parameters with the second one being optional
        public int sum(int a, int b = 0)
        {
            int add = a + b;
            return add;
        }
    }
}
