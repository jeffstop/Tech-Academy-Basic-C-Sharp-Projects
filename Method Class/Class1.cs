using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Class1
    {
        public static void Method(int first, int second)
        {
            int result = first * 5;
            Console.WriteLine(first + " multiplied by 5 = " + result);
            Console.WriteLine(second);
            return;
        }
    }
}
