using System;

using System.Collections.Generic; // Allows use of generic collections like List<T>

// Create a generic Employee class with type parameter T
public class Employee<T>
{
    // Property called Things that is a list of type T
    public List<T> Things { get; set; }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Instantiate Employee object with string type
        Employee<string> stringEmployee = new Employee<string>();

        // Assign a list of strings to the Things property
        stringEmployee.Things = new List<string>()
        {
            "Laptop",
            "Phone",
            "Notebook"
        };

        // Instantiate Employee object with int type
        Employee<int> intEmployee = new Employee<int>();

        // Assign a list of integers to the Things property
        intEmployee.Things = new List<int>()
        {
            10,
            20,
            30
        };

        // Loop through stringEmployee Things and print each item
        Console.WriteLine("String Employee Things:");
        foreach (string item in stringEmployee.Things)
        {
            Console.WriteLine(item);
        }

        // Loop through intEmployee Things and print each item
        Console.WriteLine("\nInt Employee Things:");
        foreach (int number in intEmployee.Things)
        {
            Console.WriteLine(number);
        }

        // Keep console open
        Console.ReadLine();
    }
}
