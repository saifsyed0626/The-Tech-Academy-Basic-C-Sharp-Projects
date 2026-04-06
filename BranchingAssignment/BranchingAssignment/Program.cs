using System;


namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if weight exceeds limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends program
            }

            // Prompt user for package width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt user for package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt user for package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate total dimensions
            double totalDimensions = width + height + length;

            // Check if dimensions exceed limit
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends program
            }

            // Calculate shipping quote
            double quote = (width * height * length * weight) / 100;

            // Display formatted quote as currency (2 decimal places)
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Final thank you message
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
