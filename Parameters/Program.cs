using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the day of the week:");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter correctly enter the day of the week.");
            }
            Console.ReadLine();
        }
    }
}
