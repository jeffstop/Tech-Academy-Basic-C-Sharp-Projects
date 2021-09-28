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

            // Used for spacing
            Console.WriteLine();

            
            // Infinite loop that will continue to pring true
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

            // Used for spacing
            Console.WriteLine();

            
            Console.WriteLine("Loop comparison using <:");
            // Loop comparison using "<"
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("Loop comparison using <=:");
            // Loop comparison using "<="
            int r = 0;
            while (r <= 5)
            {
                Console.WriteLine(r);
                r++;
            }

            // Used for spacing
            Console.WriteLine();

            
            // List
            List<string> strlist = new List<string>();
            strlist.Add("First string");
            strlist.Add("Second string");
            strlist.Add("Third string");
            // Display list to make searching it easier for user
            foreach (var str in strlist)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Please input your search request for the above list:");
            // User search input
            string searchstring = Console.ReadLine();
            // Bool variable for search results. False is default and means the search did not match any item on the list, while true is a match for an item
            bool found = false;
            // Iterate each item in list
            foreach (var str in strlist)
            {
                // Create variable to store index value of each item
                int index = strlist.IndexOf(str);
                // if statement to determine if search result matches item on list. If true changes bool variable "found" to equal true. Displays message on match
                if (str == searchstring)
                {
                    Console.WriteLine($"Your search matched!\nIndex value: {index}\nString: {str}");
                    found = true;
                    break;
                }
            }
            // if "found" equals false display message to user
            if (!found)
            {
                Console.WriteLine("Your search did not match any string on the list.");
            }

            Console.WriteLine();


            // List with duplicate items
            List<string> duplist = new List<string> { "Duplicate", "Not the same", "Duplicate" };
            // Iterate through each item in list
            foreach (var dupstr in duplist)
            {
                // Display list for user to see
                Console.WriteLine(dupstr);
            }
            Console.WriteLine("Please search from the list above:");
            // User search input
            string dupsearch = Console.ReadLine();
            // Bool variable for search results. False means no match, true means there is a match
            bool dupfound = false;
            // Iterate through each item in list
            foreach (var dupstr in duplist)
            {
                // Create variables to represent the index value of the first and last occurrence 
                int dupindex = duplist.IndexOf(dupstr);
                int duplastindex = duplist.LastIndexOf(dupstr);
                // if comparison statement
                if (dupstr == dupsearch)
                {
                    // Display results of search
                    Console.WriteLine($"Your search matched!\nFirst index value: {dupindex}\nLast index value: {duplastindex}\nString: {dupstr}");
                    // Change bool variable to true when there is a match
                    dupfound = true;
                    // Stops loop once a match is found
                    break;
                }
            }
            // if statement for when there is no match in the search
            if (!dupfound)
            {
                Console.WriteLine("Your search did not match any string on the list.");
            }

            // Used for spacing
            Console.WriteLine();



            // New list
            List<string> newstr = new List<string>() { "Left", "Right", "Up", "Left" };
            Console.WriteLine("Part Six:");
            Console.WriteLine();
            // Create empty list to add unique strings to
            List<string> dupes = new List<string>();
            // foreach statement
            foreach (var ns in newstr)
            {
                // Checking list "dupes" if it already contains the item "ns"
                if (dupes.Contains(ns))
                {
                    Console.WriteLine($"The string: \"{ns}\" has already appeared in the list");
                }
                // If list "dupes" doesn't contain "ns" then it's added to "dupes"
                else
                {
                    dupes.Add(ns);
                    Console.WriteLine(ns);
                }
            }
            // Display the count of unique strings in the list
            Console.WriteLine("Number of unique strings in list: " + dupes.Count);


            Console.Read();
        }
    }
}
