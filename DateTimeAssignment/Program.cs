using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DT = DateTime.Now;
            Console.WriteLine(DT);

            Console.WriteLine("Please enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNum + " hours from now is: " + DT.AddHours(userNum));

            Console.Read();
        }
    }
}
