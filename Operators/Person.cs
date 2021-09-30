using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public abstract class Person
    {
        // String properties for class Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method SayName()
        public abstract void SayName();
    }
}
