using System;


namespace Math_and_Comparison_Operator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int person1_hourly_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1_weekly_hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int person2_hourly_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person2_weekly_hours = Convert.ToInt32(Console.ReadLine());
            Console.Read();
        }
    }
}
