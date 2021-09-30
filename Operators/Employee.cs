using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    // Inherit from class "Person"
    public class Employee : Person
    {
        // Use SayName() method in class "Employee"
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
