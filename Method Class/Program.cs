using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int intOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer: ");
            int intTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Class1.MyMethod(intOne, intTwo));
            Console.ReadLine();
        }
    }
}
