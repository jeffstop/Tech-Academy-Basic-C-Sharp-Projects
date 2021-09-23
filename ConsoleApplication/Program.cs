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

            // Foreach loop to print each element in array "stringArray"
            foreach (string i in stringArray)
            {
                Console.WriteLine(i);
            }

            // Infinite loop
            //bool infinite = true;
            //while (infinite == true)
            //{
            //Console.WriteLine(infinite);
            //}

            Console.WriteLine("Fixed infinite loop:");

            // Fixed infinite loop
            bool infinite = true;
            while (infinite == true)
            {
                infinite = false;
                Console.WriteLine(infinite);
            }

            Console.Read();

            Console.WriteLine("Loop comparison using <:");
            // Loop comparison using "<"
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.Read();

            Console.WriteLine("Loop comparison using <=:");
            // Loop comparison using "<="
            int r = 0;
            while (r <= 5)
            {
                Console.WriteLine(r);
                r++;
            }

            // List
            List<string> strlist = new List<string>();
            strlist.Add("First string");
            strlist.Add("Second string");
            strlist.Add("Third string");

            Console.WriteLine("Please input your search:");
            string searchstring = Console.ReadLine();
            bool found = false;
            foreach (var str in strlist)
            {
                int index = strlist.IndexOf(str);

                if (str == searchstring)
                {
                    Console.WriteLine($"Your search matched!\nIndex value: {index}\nString: {str}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Your search did not match any string on the list.");
            }
            

            Console.Read();
        }
    }
}
