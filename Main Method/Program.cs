using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to add to 12:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Class1.Addition(userNum, 12));
            Console.ReadLine();
        }
    }
}
