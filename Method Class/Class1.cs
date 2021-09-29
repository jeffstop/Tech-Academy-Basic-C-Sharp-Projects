using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Class1
    {
        public static void MyMethod(int intOne, int intTwo)
        {
            int result = intOne * 5;
            Console.WriteLine($"{intOne} multiplied by 5 = {result}");
            Console.WriteLine(intTwo);
        }
    }
}
