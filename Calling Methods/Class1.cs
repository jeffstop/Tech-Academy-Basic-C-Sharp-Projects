using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Class1
    {
        // Method for adding the user's chosen number to another number
        public static int Sum(int userNum, int y)
        {
            int a = userNum;
            int b = y;

            int result = a + b;

            return result;
        }

        // Method for multiplying the user's number
        public static int Multiply(int userNum, int y)
        {
            int a = userNum;
            int b = y;

            int result = a * b;

            return result;
        }

        // Method for dividing the user's number
        public static int Divide(int userNum, int y)
        {
            int a = userNum;
            int b = y;

            int result = a / b;

            return result;
        }
    }
}
