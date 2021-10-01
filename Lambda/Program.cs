﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){FirstName="Frank", LastName="Couch", EmployeeID=3},
                new Employee(){FirstName="Joe", LastName="Smith", EmployeeID=7},
                new Employee(){FirstName="Dan", LastName="Washington", EmployeeID=2},
                new Employee(){FirstName="Jerry", LastName="Wagner", EmployeeID=8},
                new Employee(){FirstName="Margaret", LastName="White", EmployeeID=9},
                new Employee(){FirstName="Nancy", LastName="Blue", EmployeeID=6},
                new Employee(){FirstName="Phil", LastName="Twelve", EmployeeID=11},
                new Employee(){FirstName="Joe", LastName="East", EmployeeID=4},
                new Employee(){FirstName="Ashley", LastName="Fort", EmployeeID=1},
                new Employee(){FirstName="Janet", LastName="Hill", EmployeeID=10}
            };

            List<Employee> dupJoe = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    dupJoe.Add(employee);
                }
            }


            List<Employee> lamJoe = employeeList.Where(x => x.FirstName.Contains("Joe")).ToList();


            List<Employee> lamID = employeeList.Where(x => x.EmployeeID > 5).ToList();


            Console.WriteLine("Number of employees named \"Joe\":");
            Console.WriteLine(lamJoe.Count);
            Console.WriteLine("Number of employees with ID's greater than 5:");
            Console.WriteLine(lamID.Count);

            Console.ReadLine();

        }
    }
}
