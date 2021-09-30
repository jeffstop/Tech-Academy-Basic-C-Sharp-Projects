using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Math
    {
        public void MyMethod(int num, out int result)
        {
            result = num / 2;
        }

        public void MetOut(out int output1)
        {
            output1 = 37;
        }

        public int MetOverload(int a, int b)
        {
            return a + b;
        }
        public int MetOverload(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
