using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Class1
    {
        public static int Addition(int userNum, int y)
        {
            int result = userNum + y;

            return result;
        }

        public static decimal Multiply(decimal userInput, int y)
        {
            decimal result = (int)userInput * y;

            return (decimal)result;
        }

        public static double Multi(double userString, double y)
        {
            double result = userString * y;

            return result;
        }
    }
}
