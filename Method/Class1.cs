using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Class1
    {
        // Method math operation. If no user input for second number, the default value is 5
        public static int Method(int x, int y = 5)
        {
            int result = x * y;

            return result;
        }
    }
}
