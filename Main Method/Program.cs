using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to add to 12:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Class1.Addition(userNum, 12));

            Console.WriteLine("Enter a decimal number to be mulitplied by 5:");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Class1.Multiply(userInput, 5));


            Console.ReadLine();
        }
    }
}
