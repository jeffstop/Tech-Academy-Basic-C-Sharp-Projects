using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 8, 14, 22, 40, 60 };
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("Please input a number to divide by each number on the list:");
                int divnum = Convert.ToInt32(Console.ReadLine());
                foreach (var num in numbers)
                {
                    int division = num / divnum;
                    Console.WriteLine(division);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by 0", e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("You must enter an integer", e);
            }

            Console.Read();
        }
    }
}
