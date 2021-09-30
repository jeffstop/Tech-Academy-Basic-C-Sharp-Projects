﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
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

        public static bool operator ==(Employee one, Employee two)
        {
            if (one.EmployeeID == two.EmployeeID)
            {
                Console.WriteLine("Employee ID's are equal");
                return true;
            }
            else
            {
                Console.WriteLine("Employee ID's are not equal");
                return false;
            }
        }

        public static bool operator !=(Employee one, Employee two)
        {
            if (one.EmployeeID == two.EmployeeID)
            {
                Console.WriteLine("Employee ID's are equal");
                return false;
            }
            else
            {
                Console.WriteLine("Employee ID's are not equal");
                return true;
            }
        }
    }
}
