using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Abstract class
    public abstract class Person
    {
        // String properties for abstract class "Person"
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method "SayName"
        public abstract void SayName();
    }
}
