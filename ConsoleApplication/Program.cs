using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array "stringArray"
            string[] stringArray = { "This is the first string.", "The second string.", "Third string." };
            Console.WriteLine("Please input a string:");
            // User input
            string userString = Console.ReadLine();

            // For loop to add user input to the end of each element in array "stringArray"
            for (int n = 0; n < stringArray.Length; n++) 
            {
                string concstring = stringArray[n] + " " + userString;
                stringArray[n] = concstring; 
            }
            
            // Foreach loop to print each element in array
            foreach (string i in stringArray) 
            {
                Console.WriteLine(i);
            }

            // Infinite loop
            bool infinite = true;
            while (infinite == true)
            {
                Console.WriteLine(infinite);
            }
            Console.Read();

        }
    }
}
