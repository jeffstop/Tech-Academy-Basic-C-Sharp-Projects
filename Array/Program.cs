using System;
using System.Collections.Generic;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Array
            string[] cars = { "BMW", "Subaru", "Ford", "Audi", "KIA" };
            Console.WriteLine("Select a number between 0-4 to select a car.");
            int stringnumber = Convert.ToInt32(Console.ReadLine());
                if (stringnumber > 4)
                {
                Console.WriteLine("You did not select a number between 0-4. Goodbye");
                Console.Read();
                Environment.Exit(-1);
                }
            Console.WriteLine(cars[stringnumber]);

            // Integer Array
            int[] numbers = { 10, 15, 20, 25, 30 };
            Console.WriteLine("Select a number between 0-4 to select a number.");
            int intnumber = Convert.ToInt32(Console.ReadLine());
            if (intnumber > 4)
            {
                Console.WriteLine("You did not select a number between 0-4. Goodbye");
                Console.Read();
                Environment.Exit(-1);
            }
            Console.WriteLine(numbers[intnumber]);

            Console.Read();
        }
    }
}
