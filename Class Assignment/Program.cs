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
            // Instantiate class
            Math math = new Math();

            // Get number from user
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Create integer variable to display method output
            int a;
            math.MyMethod(num, out a);
            Console.WriteLine(num + " / 2 = " + a);
            Console.WriteLine();


            // Create variable for method with output parameters
            int z;
            int y;
            math.MetOut(out z, out y);
            Console.WriteLine("Method with output parameters: " + z + " & " + y);
            Console.WriteLine();


            // Call and display overloaded method
            int overload1 = math.MetOverload(5, 10);
            int overload2 = math.MetOverload(7, 12, 15);
            Console.WriteLine("First overload method:\n5 + 10 = " + overload1);
            Console.WriteLine();
            Console.WriteLine("Second overload method:\n7 + 12 + 15 = " + overload2);
            Console.WriteLine();


            // Call static class
            Console.WriteLine("This is a static class:\n5 * 5 = " + StaticClass.Product(5, 5));

            Console.ReadLine();
        }
    }
}
