using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create list of integers
                List<int> numbers = new List<int> { 8, 14, 22, 40, 60 };
                // Display list to user
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("Please input a number to divide by each number on the list:");
                // User input represented by variable "divnum"
                int divnum = Convert.ToInt32(Console.ReadLine());
                foreach (var num in numbers)
                {
                    // Variable "division" represents the value of a list number divided by the user's input
                    int division = num / divnum;
                    // Display results of each division
                    Console.WriteLine(division);
                }
            }
            // Catch block for when a user divides by 0
            catch (DivideByZeroException e)
            {
                // Tell user they cannot divide by 0
                Console.WriteLine("You cannot divide by 0", e);
            }
            // Catch block for when a user inputs a format other than an integer
            catch (FormatException e)
            {
                // Tell user to enter an integer
                Console.WriteLine("You must enter an integer", e);
            }
            // Catch block for any other error
            catch (Exception e)
            {
                // Display error message
                Console.WriteLine(e.Message);
            }
            // Finally block to allow user to see error message
            finally
            {
                Console.ReadLine();
            }

            // Message to inform user that the try/catch portion of the program is done
            Console.WriteLine("The program is done with the try/catch block");

            Console.Read();
        }
    }
}
