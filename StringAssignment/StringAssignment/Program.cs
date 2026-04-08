using System;


namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Concatenate three strings
            string firstName = "Saif";
            string lastName = "Ali";
            string greeting = "Hello";

            // Combine the three strings into one sentence
            string fullMessage = greeting + " " + firstName + " " + lastName;
            Console.WriteLine("Concatenated string: " + fullMessage);

            // 2. Convert a string to uppercase
            string upperMessage = fullMessage.ToUpper(); // Converts entire string to uppercase
            Console.WriteLine("Uppercase version: " + upperMessage);

            // 3. Create a StringBuilder and build a paragraph
            StringBuilder paragraph = new StringBuilder(); // Initialize StringBuilder

            // Add sentences one at a time
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("Here is the second sentence. ");
            paragraph.Append("Finally, this is the third sentence.");

            // Display the full paragraph
            Console.WriteLine("Paragraph built with StringBuilder:");
            Console.WriteLine(paragraph);

            // Keep console open
            Console.ReadLine();
        }
    }
}
