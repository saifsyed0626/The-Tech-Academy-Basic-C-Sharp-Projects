using System;

// Define an interface called IQuittable
// Interfaces only contain method signatures (no implementation)
public interface IQuittable
{
    // Define a void method called Quit()
    void Quit();
}

// Abstract class Person (from previous assignment)
public abstract class Person
{
    // Property for first name
    public string firstName { get; set; }

    // Property for last name
    public string lastName { get; set; }

    // Abstract method that must be implemented in derived classes
    public abstract void SayName();
}

// Employee class inherits from Person AND implements IQuittable
public class Employee : Person, IQuittable
{
    // Implement the SayName() method from Person
    public override void SayName()
    {
        // Print full name to console
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }

    // Implement the Quit() method from IQuittable interface
    public void Quit()
    {
        // You can define this behavior however you like
        Console.WriteLine(firstName + " " + lastName + " has quit the job.");
    }
}

// Main program class
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Create an Employee object and initialize properties
        Employee emp = new Employee();
        emp.firstName = "Sample";
        emp.lastName = "Student";

        // Call SayName() method
        emp.SayName();

        // Use polymorphism:
        // Create an object of type IQuittable but assign it an Employee instance
        IQuittable quittableObj = emp;

        // Call the Quit() method using the interface reference
        quittableObj.Quit();

        // Keep console open
        Console.ReadLine();
    }
}
