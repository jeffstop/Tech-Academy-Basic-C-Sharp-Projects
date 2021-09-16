using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
                if (weight > 50)
                {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Console.Read() is placed here so the console doesn't immediately close
                Console.Read();
                // This closes the program. There must be an integer for this to work
                Environment.Exit(-1);
                }

            Console.WriteLine("Please enter the package width:");

            Console.WriteLine("Please enter the package height:");

            Console.WriteLine("Please enter the package length:");
            Console.Read();
        }
    }
}
