using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to do three math operations on:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int result1 = Class1.Sum(userNum, 8);
            Console.WriteLine($"The sum of {userNum} and 8 equals: {result1}");
            Console.ReadLine();

            int result2 = Class1.Multiply(userNum, 5);
            Console.WriteLine($"The product of {userNum} and 5 equals: {result2}");
            Console.ReadLine();

            int result3 = Class1.Divide(userNum, 2);
            Console.WriteLine($"The division of {userNum} by 2 equals: {result3}");
            Console.ReadLine();
        }
    }
}
