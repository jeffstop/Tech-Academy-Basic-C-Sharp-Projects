using System;


namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            // User age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // DUI
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false.\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // Speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Qualified
            Console.WriteLine("Qualified?");
            // User must be older than 15, have no dui's, and less than 3 speeding tickets to qualify
            bool qualified = (age > 15 && dui == false && tickets < 3);
            Console.WriteLine(qualified);
            Console.Read();
        }
    }
}
