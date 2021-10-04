using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        public class Dog
        {
            // Create const variable
            const string Species = "Canis familiaris";
            public string Breed { get; set; }
            public int Age { get; set; }

            // Create constructors
            public Dog (string breed, int age)
            {
                Breed = breed;
                Age = age;
            }
            public Dog(string breed) : this(breed, 3)
            {

            }
            public Dog(int age) : this("Breed", age)
            {

            }
        }

        static void Main(string[] args)
        {
            // Create variable with "var"
            var dog1 = new Dog("Australian Shepherd", 5);
            // Chain two constructors
            Console.WriteLine("Breed: " + dog1.Breed + "\nAge: " + dog1.Age);
            Console.Read();
        }
    }
}
