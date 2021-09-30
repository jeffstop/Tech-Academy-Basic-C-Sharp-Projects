using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number:");

            int num = Convert.ToInt32(Console.ReadLine());

            int a;

            Math.myMethod(num, out a);
            Console.WriteLine(num + " / 2 = " + a);


            Console.ReadLine();
        }
    }
}
