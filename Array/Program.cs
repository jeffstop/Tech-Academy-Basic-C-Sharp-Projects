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
            // User picks an index in the array
            int stringnumber = Convert.ToInt32(Console.ReadLine());
                // if statement to close program when a number greater than 4 is chosen
                if (stringnumber > 4)
                {
                Console.WriteLine("You did not select a number between 0-4. Goodbye");
                // Allow user to read message before closing program
                Console.Read();
                // Close program
                Environment.Exit(-1);
                }
            // Print chosen index in the array
            Console.WriteLine(cars[stringnumber]);

            // Integer Array
            int[] numbers = { 10, 15, 20, 25, 30 };
            Console.WriteLine("Select a number between 0-4 to select a number.");
            // User picks an index in the array
            int intnumber = Convert.ToInt32(Console.ReadLine());
                // if statement to close program when a number greater than 4 is chosen
                if (intnumber > 4)
                {
                    Console.WriteLine("You did not select a number between 0-4. Goodbye");
                    // Allow user to read message before closing program
                    Console.Read();
                    // Close program
                    Environment.Exit(-1);
                }
            // Print chosen index in the array
            Console.WriteLine(numbers[intnumber]);
            // Keeps console open
            Console.Read();
        }
    }
}
