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
            const string Species = "Canis familiaris";
            public string Breed { get; set; }
            public int Age { get; set; }

            public Dog (string breed, int age)
            {
                Breed = breed;
                Age = age;
            }

            public Dog(string breed) : this(breed, 3)
            {

            }

            public Dog(int age) : this("Australian Shepherd", age)
            {

            }
        }

        static void Main(string[] args)
        {
            var dog1 = new Dog("Australian Shepherd");
            Console.WriteLine(dog1.Breed + " . Age: " + dog1.Age);
            Console.ReadLine();
        }
    }
}
