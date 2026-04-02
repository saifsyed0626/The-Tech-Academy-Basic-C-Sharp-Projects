using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Take input, multiply by 50, and display result
            Console.WriteLine("Enter a number to multiply by 50:");
            long input1 = Convert.ToInt64(Console.ReadLine()); // Use long for large numbers
            long result1 = input1 * 50;
            Console.WriteLine("Result: " + result1);

            // 2. Take input, add 25, and display result
            Console.WriteLine("\nEnter a number to add 25:");
            long input2 = Convert.ToInt64(Console.ReadLine());
            long result2 = input2 + 25;
            Console.WriteLine("Result: " + result2);

            // 3. Take input, divide by 12.5, and display result
            Console.WriteLine("\nEnter a number to divide by 12.5:");
            double input3 = Convert.ToDouble(Console.ReadLine()); // Use double for decimal division
            double result3 = input3 / 12.5;
            Console.WriteLine("Result: " + result3);

            // 4. Take input, check if greater than 50, and display true/false
            Console.WriteLine("\nEnter a number to check if greater than 50:");
            int input4 = Convert.ToInt32(Console.ReadLine());
            bool result4 = input4 > 50;
            Console.WriteLine("Is greater than 50? " + result4);

            // 5. Take input, divide by 7 and display the remainder
            Console.WriteLine("\nEnter a number to divide by 7 and get the remainder:");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int result5 = input5 % 7; // % gives the remainder
            Console.WriteLine("Remainder: " + result5);

            // Keeps the console window open until user presses Enter
            Console.ReadLine();
        }
    }
}

