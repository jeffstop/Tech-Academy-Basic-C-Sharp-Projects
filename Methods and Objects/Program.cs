using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class and give object "employee" a name
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Display object "employee"
            employee.SayName();
            Console.ReadLine();
        }
    }
}
