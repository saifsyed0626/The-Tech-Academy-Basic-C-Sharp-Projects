using System;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE LOOP EXAMPLE
            // This loop will run as long as the condition is true

            int number = 1; // Initialize variable

            Console.WriteLine("While loop starting:");

            // Loop continues while number is less than or equal to 5
            while (number <= 5)
            {
                Console.WriteLine("Current number (while): " + number);
                number++; // Increment number each iteration
            }

            // DO-WHILE LOOP EXAMPLE
            // This loop will run at least once, even if the condition is false

            int number2 = 1; // Initialize second variable

            Console.WriteLine("Do-While loop starting:");

            do
            {
                Console.WriteLine("Current number (do-while): " + number2);
                number2++; // Increment number each iteration
            }
            // Condition is checked AFTER the loop runs once
            while (number2 <= 5);

            // Keep console open
            Console.ReadLine();
        }
    }
}
