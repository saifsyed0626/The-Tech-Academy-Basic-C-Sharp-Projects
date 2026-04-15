using System;

// Create an abstract class called Person
public abstract class Person
{
    // Property to store the first name
    public string firstName { get; set; }

    // Property to store the last name
    public string lastName { get; set; }

    // Declare an abstract method (no body here)
    // This must be implemented in any non-abstract child class
    public abstract void SayName();
}

// Create a class called Employee that inherits from Person
public class Employee : Person
{
    // Implement (override) the abstract SayName() method
    public override void SayName()
    {
        // Display the full name in the required format
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}

// Main program class
class Program
{
    // Entry point of the console application
    static void Main(string[] args)
    {
        // Instantiate an Employee object
        Employee emp = new Employee();

        // Initialize the properties of the Employee object
        emp.firstName = "Sample";   // Set first name
        emp.lastName = "Student";   // Set last name

        // Call the SayName() method
        emp.SayName();

        // Keep console open until a key is pressed
        Console.ReadLine();
    }
}
