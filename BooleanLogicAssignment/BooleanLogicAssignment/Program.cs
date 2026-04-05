using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask the user if they have ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask the user how many speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Apply the business rules:
            // Must be over 15 years old
            // Must NOT have a DUI
            // Must NOT have more than 3 speeding tickets
            bool isQualified = (age > 15) && (hasDUI == false) && (tickets <= 3);

            // Print the result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

            // Keep console open
            Console.ReadLine();
        }
    }
}
