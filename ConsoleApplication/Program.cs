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
            string[] stringArray = { "This is the first string.", "The second string.", "Third string." };
            Console.WriteLine("Please input a string:");
            string userString = Console.ReadLine();

            for (int n = 0; n < stringArray.Length; n++) 
            {
                string concstring = stringArray[n] + " " + userString;
                stringArray[n] = concstring; 
            }
            
            
            foreach (string i in stringArray) 
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
