using System;


namespace While_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // while statement
            int i = 0;
            // Loop until i is 5 or greater
            while (i < 5)
            {
                // Writes i for every iteration
                Console.WriteLine(i);
                // Add 1 to the value of i
                i++;
            }


            // do while statement
            int n = 0;
            do
            {
                // Writes n for every iteration
                Console.WriteLine(n);
                // Add 1 to the value of n
                n++;
            }
            // Stops loop once n is 5 or greater
            while (n < 5);

            Console.Read();
        }
    }
}
