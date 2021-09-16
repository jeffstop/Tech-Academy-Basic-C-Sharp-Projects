using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // Package Weight
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

            // Package Width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Package Height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Package Length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());
                // 
                if (width + height + length > 50)
                {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // 
                Console.Read();
                // 
                Environment.Exit(-1);
                }

            
            Console.Read();
        }
    }
}
