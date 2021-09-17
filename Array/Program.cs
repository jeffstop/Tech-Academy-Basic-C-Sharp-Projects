using System;
using System.Collections.Generic;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Subaru", "Ford", "Audi", "KIA" };
            Console.WriteLine("Select a number between 0-4");
            int stringnumber = Convert.ToInt32(Console.ReadLine());
                if (stringnumber > 4)
                {
                Console.WriteLine("You did not select a number between 0-4. Goodbye");
                Console.Read();
                Environment.Exit(-1);
                }
            Console.WriteLine(cars[stringnumber]);
            Console.Read();
        }
    }
}
