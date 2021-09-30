using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Employee inherits class "Person" and interface "IQuittable"
    class Employee : Person, IQuittable
    {
        // Method "SayName"
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Method "Quit" writes "Goodbye"
        public void Quit()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
