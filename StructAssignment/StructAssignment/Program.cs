using System;

// Define a struct called Number
// A struct is a value type used to store small data structures
public struct Number
{
    // Property called Amount of type decimal
    public decimal Amount { get; set; }
}

// Main program class
class Program
{
    // Entry point of the console application
    static void Main(string[] args)
    {
        // Create an instance of the Number struct
        Number num = new Number();

        // Assign a value to the Amount property
        num.Amount = 123.45m; // 'm' indicates a decimal literal

        // Print the Amount to the console
        Console.WriteLine("The amount is: " + num.Amount);

        // Keep console window open until user presses a key
        Console.ReadLine();
    }
}