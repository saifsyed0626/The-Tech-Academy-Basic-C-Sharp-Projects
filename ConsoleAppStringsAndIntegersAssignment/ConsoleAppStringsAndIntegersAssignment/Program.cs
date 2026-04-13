using System;
using System.Collections.Generic;

namespace ConsoleAppDivisionAssignment
{
    class Program
    {
        static void Main()
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            try
            {
                // Ask the user for a number to divide by
                Console.Write("Enter a number to divide each list value by: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // Loop through each number in the list
                for (int i = 0; i < numbers.Count; i++)
                {
                    // Perform division
                    int result = numbers[i] / userNumber;

                    // Display result
                    Console.WriteLine(numbers[i] + " divided by " + userNumber + " = " + result);
                }
            }
            catch (FormatException ex)
            {
                // Handles non-integer input (like strings)
                Console.WriteLine("Error: You must enter a valid whole number.");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                // Handles division by zero
                Console.WriteLine("Error: You cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Handles any other unexpected errors
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }

            // Message that always runs after try/catch block
            Console.WriteLine("\nProgram has exited the try/catch block and continued execution.");

            // Keeps console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
