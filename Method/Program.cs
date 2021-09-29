using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int userInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(Optional)Please enter another number: ");
            string userString = Console.ReadLine();

            if (userString != "")
            {
                int x = Convert.ToInt32(userString);
                Console.WriteLine(Class1.Method(x));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(Class1.Method(userInt));
                Console.ReadLine();
            }
        }
    }
}
