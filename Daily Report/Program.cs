using System;


namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            // Display starting text
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            // This saves the user's input as "name"
            string name = Console.ReadLine();
            Console.WriteLine("What Course are you on?");
            // This saves the user's input as "course"
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            // This saves the user's input as "page." Data type must be converted to int
            int page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            // This saves the user's input as "help." Data type must be converted to bool
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            // This saves the user's input as "experience"
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            // This saves the user's input as "feedback"
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            // This saves the user's input as "hours." Data type must be converted to int
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            // Keeps console open
            Console.Read();
        }
    }
}
