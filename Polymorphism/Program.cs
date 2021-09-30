using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee as "Sample Student"
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();

            // Use polymorphism to create an object of IQuittable and call the method "Quit"
            employee.Quit();

            Console.ReadLine();
        }
    }
}
