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
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                Console.WriteLine("Today is {0}", day.ToString());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please correctly enter the day of the week.");
            }
            Console.ReadLine();
        }
    }
}
