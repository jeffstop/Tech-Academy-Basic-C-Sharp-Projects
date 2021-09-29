using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Class1
    {
        // Create method "MyMethod" with two integers as parameters
        public static void MyMethod(int intOne, int intTwo)
        {
            // Multiply first integer by 5
            int result = intOne * 5;
            // Display "result"
            Console.WriteLine($"{intOne} multiplied by 5 = {result}");
            // Display unused integer
            Console.WriteLine("Unused integer: " + intTwo);
            return;
        }
    }
}
