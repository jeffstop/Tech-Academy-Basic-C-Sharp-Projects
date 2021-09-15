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
            Console.WriteLine("Annual salary of Person 1:");
            int product1 = person1_hourly_rate * person1_weekly_hours * 52;
            Console.WriteLine(product1);
            Console.WriteLine("Annual salary of Person 2:");
            int product2 = person2_hourly_rate * person2_weekly_hours * 52;
            Console.WriteLine(product2);
            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(product1 >= product2);
            Console.Read();
        }
    }
}
