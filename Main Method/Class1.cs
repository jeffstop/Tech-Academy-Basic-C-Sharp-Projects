using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Class1
    {
        // Add user's integer to another integer
        public static int Addition(int userNum, int y)
        {
            int result = userNum + y;

            return result;
        }

        // Multiply user's decimal by an integer and return an integer as the answer
        public static decimal Multiply(decimal userInput, int y)
        {
            int result = (int)userInput * y;

            return result;
        }

        // Multiplies user's input by an integer
        public static double Multi(int userString, int y)
        {
            int result = userString * y;

            return result;
        }
    }
}
