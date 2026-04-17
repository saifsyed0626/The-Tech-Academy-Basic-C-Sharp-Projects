using System;
using System.IO; // Needed for file handling (reading/writing files)

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");

            // Read the user's input from the console and store it as a string
            string userInput = Console.ReadLine();

            // Define the file path where the number will be saved
            string filePath = "numbers.txt";

            // Write the user's input to the text file
            // If the file does not exist, it will be created
            File.WriteAllText(filePath, userInput);

            // Let the user know the number has been saved
            Console.WriteLine("Your number has been saved to the file.");

            // Read the contents of the text file
            string fileContents = File.ReadAllText(filePath);

            // Display the contents of the file back to the user
            Console.WriteLine("Here is the content of the file:");
            Console.WriteLine(fileContents);

            // Pause the console so the user can see the output before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}