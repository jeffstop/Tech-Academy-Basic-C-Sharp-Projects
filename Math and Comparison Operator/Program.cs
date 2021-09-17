using System;


namespace Math_and_Comparison_Operator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person 1
            Console.WriteLine("Person 1");

            // User enters Person 1's hourly rate and hours per week
            Console.WriteLine("Hourly Rate?");
            int person1_hourly_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1_weekly_hours = Convert.ToInt32(Console.ReadLine());

            // Person 2
            Console.WriteLine("Person 2");

            // User enters Person 2's hourly rate and hours per week
            Console.WriteLine("Hourly Rate?");
            int person2_hourly_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person2_weekly_hours = Convert.ToInt32(Console.ReadLine());

            // Person 1 annual salary
            Console.WriteLine("Annual salary of Person 1:");
            int product1 = person1_hourly_rate * person1_weekly_hours * 52;
            Console.WriteLine(product1);

            // Person 2 annual salary
            Console.WriteLine("Annual salary of Person 2:");
            int product2 = person2_hourly_rate * person2_weekly_hours * 52;
            Console.WriteLine(product2);

            // Compare Person 1 salary to Person 2 salary
            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(product1 > product2);
            Console.Read();
        }
    }
}
