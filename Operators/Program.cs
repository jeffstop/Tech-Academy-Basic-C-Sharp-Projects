using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee as "Sample Student"
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //employee.SayName();

            // Use polymorphism to create an object of IQuittable and call the method "Quit"
            //IQuittable quit = new Employee();
            //quit.Quit();

            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", EmployeeID = 404 };
            Employee employee2 = new Employee() { FirstName = "Example", LastName = "Scholar", EmployeeID = 405 };

            bool idcheck = employee1 == employee2;
            Console.WriteLine(idcheck);

            Console.ReadLine();
        }
    }
}
