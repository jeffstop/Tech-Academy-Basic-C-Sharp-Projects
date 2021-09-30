using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee object with the name "Sample Student"
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Call SayName method on employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
