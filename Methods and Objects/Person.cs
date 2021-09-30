using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Person
    {
        // Give class Person string properties of "FirstName" and "LastName"
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method for displaying the first and last name of a "Person"
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
