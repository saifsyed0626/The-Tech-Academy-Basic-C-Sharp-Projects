using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================
            // 1. ARRAY OF STRINGS
            // ================================

            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Ask the user to select an index
            Console.WriteLine("STRING ARRAY");
            Console.Write("Enter an index (0 - 4): ");

            // Read user input and convert to integer
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index is valid
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at that index
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            else
            {
                // Display error message if index doesn't exist
                Console.WriteLine("Invalid index. That position does not exist in the array.");
            }

            Console.WriteLine(); // Blank line for spacing

            // ================================
            // 2. ARRAY OF INTEGERS
            // ================================

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index
            Console.WriteLine("INTEGER ARRAY");
            Console.Write("Enter an index (0 - 4): ");

            // Read user input and convert to integer
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index is valid
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at that index
                Console.WriteLine("You selected: " + intArray[intIndex]);
            }
            else
            {
                // Display error message if index doesn't exist
                Console.WriteLine("Invalid index. That position does not exist in the array.");
            }

            Console.WriteLine();

            // ================================
            // 3. LIST OF INTEGERS
            // ================================

            // Create a list of integers
            List<int> intList = new List<int>() { 5, 15, 25, 35, 45 };

            // Ask the user to select an index
            Console.WriteLine("INTEGER LIST");
            Console.Write("Enter an index (0 - 4): ");

            // Read user input and convert to integer
            int listIntIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index is valid
            if (listIntIndex >= 0 && listIntIndex < intList.Count)
            {
                // Display the value at that index
                Console.WriteLine("You selected: " + intList[listIntIndex]);
            }
            else
            {
                // Display error message if index doesn't exist
                Console.WriteLine("Invalid index. That position does not exist in the list.");
            }

            Console.WriteLine();

            // ================================
            // 4. LIST OF STRINGS
            // ================================

            // Create a list of strings
            List<string> stringList = new List<string>() { "Red", "Blue", "Green", "Yellow", "Purple" };

            // Ask the user to select an index
            Console.WriteLine("STRING LIST");
            Console.Write("Enter an index (0 - 4): ");

            // Read user input and convert to integer
            int listStringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index is valid
            if (listStringIndex >= 0 && listStringIndex < stringList.Count)
            {
                // Display the value at that index
                Console.WriteLine("You selected: " + stringList[listStringIndex]);
            }
            else
            {
                // Display error message if index doesn't exist
                Console.WriteLine("Invalid index. That position does not exist in the list.");
            }

            Console.WriteLine();

            // Pause the program so the user can see the results before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
