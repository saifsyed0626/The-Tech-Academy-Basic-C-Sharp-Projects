using System;

// Create a class called Person
public class Person
{
    // Property to store the first name
    public string FirstName { get; set; }

    // Property to store the last name
    public string LastName { get; set; }

    // Method that prints the full name to the console
    public void SayName()
    {
        // Display the full name in the required format
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}

// Create a class called Employee that inherits from Person
public class Employee : Person
{
    // Property to store the employee ID
    public int Id { get; set; }
}

// Main program class
class Program
{
    // Entry point of the console application
    static void Main(string[] args)
    {
        // Create a new Employee object
        Employee emp = new Employee();

        // Initialize the Employee object's properties
        emp.FirstName = "Sample";   // Set first name
        emp.LastName = "Student";   // Set last name
        emp.Id = 1;                 // Set employee ID

        // Call the inherited SayName() method from Person class
        emp.SayName();

        // Keep the console window open until user presses a key
        Console.ReadLine();
    }
}
