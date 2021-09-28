using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Class1
    {
        public static int Sum(int userNum, int y)
        {
            int a = userNum;
            int b = y;

            int result = a + b;

            return result;
        }

        public static int Multiply(int userNum, int y)
        {
            int a = userNum;
            int b = y;

            int result = a * b;

            return result;
        }

        public static int Divide(int userNum, int y)
        {
            int a = userNum;
            int b = y;

            int result = a / b;

            return result;
        }
    }
}
