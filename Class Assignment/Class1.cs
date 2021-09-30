using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Math
    {
        public void myMethod(int num, out int result)
        {
            result = num / 2;
        }

        public void metOut(out int output1, out int output2)
        {
            output1 = 6;
            output2 = 14;
        }

    }
}
