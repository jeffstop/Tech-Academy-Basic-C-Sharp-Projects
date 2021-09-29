using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Class1
    {
        public static int Method(int x, int y = 5)
        {
            int result = x * y;

            return result;
        }
    }
}
