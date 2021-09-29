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
            // Get number from user and call method "Addition"
            Console.WriteLine("Please enter a number to add to 12:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Class1.Addition(userNum, 12));

            // Get number from user and call method "Multiply"
            Console.WriteLine("Enter a decimal number to be mulitplied by 5:");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Class1.Multiply(userInput, 5));

            //Get number from user and call method "Multi"
            Console.WriteLine("Enter a number to be multiplied by 9:");
            string userString = Console.ReadLine();
            int dub = Convert.ToInt32(userString);
            Console.WriteLine(Class1.Multi(dub, 9));
            Console.ReadLine();
        }
    }
}
