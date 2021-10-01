using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    // Inherit from class "Person"
    class Employee : Person, IQuittable
    {
        public int EmployeeID { get; set; }

        // Use SayName() method in class "Employee"
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        // Method Quit() writes "Goodbye"
        public void Quit()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
