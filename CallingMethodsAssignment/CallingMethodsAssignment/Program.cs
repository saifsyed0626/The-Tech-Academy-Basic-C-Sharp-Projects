using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main()
        {
            // Ask the user for a number
            Console.Write("Enter a number to perform math operations on: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call each method and store the results
            int result1 = mathOps.AddTen(userNumber);
            int result2 = mathOps.MultiplyByTwo(userNumber);
            int result3 = mathOps.SubtractFive(userNumber);

            // Display the results to the console
            Console.WriteLine("\nResults:");
            Console.WriteLine("Add 10: " + result1);
            Console.WriteLine("Multiply by 2: " + result2);
            Console.WriteLine("Subtract 5: " + result3);

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
