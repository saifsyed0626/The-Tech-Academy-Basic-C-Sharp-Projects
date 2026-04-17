using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user to enter their age
                Console.WriteLine("Please enter your age:");

                // Read the input from the user and store it as a string
                string input = Console.ReadLine();

                // Convert the input string to an integer
                int age = Convert.ToInt32(input);

                // Check if the age is zero or negative
                if (age <= 0)
                {
                    // Throw an exception manually for invalid age
                    throw new ArgumentException("Age must be greater than zero.");
                }

                // Get the current year from the system
                int currentYear = DateTime.Now.Year;

                // Calculate the birth year by subtracting age from current year
                int birthYear = currentYear - age;

                // Display the calculated birth year to the user
                Console.WriteLine("You were born in the year: " + birthYear);
            }
            catch (ArgumentException ex)
            {
                // Handle the case where age is zero or negative
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                // Handle the case where the user enters non-numeric input
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (Exception)
            {
                // Handle any other unexpected errors
                Console.WriteLine("An unexpected error occurred. Please try again.");
            }

            // Pause the console so the user can read the output before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}