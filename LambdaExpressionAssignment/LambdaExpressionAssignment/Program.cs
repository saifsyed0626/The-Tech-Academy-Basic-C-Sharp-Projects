using System;
using System.Collections.Generic; // Allows use of List<T>
using System.Linq; // Required for lambda expressions like Where()

// Define Employee class
public class Employee
{
    // Property for employee ID
    public int Id { get; set; }

    // Property for first name
    public string FirstName { get; set; }

    // Property for last name
    public string LastName { get; set; }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Create a list of Employee objects
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Mike", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Sara", LastName = "Davis" },
            new Employee { Id = 6, FirstName = "Chris", LastName = "Wilson" },
            new Employee { Id = 7, FirstName = "Anna", LastName = "Taylor" },
            new Employee { Id = 8, FirstName = "David", LastName = "Anderson" },
            new Employee { Id = 9, FirstName = "Emma", LastName = "Thomas" },
            new Employee { Id = 10, FirstName = "Liam", LastName = "Moore" }
        };

        // Create a new list for employees named "Joe" using a foreach loop
        List<Employee> joeEmployees = new List<Employee>();

        foreach (Employee emp in employees)
        {
            // Check if the FirstName property equals "Joe"
            if (emp.FirstName == "Joe")
            {
                // Add matching employee to new list
                joeEmployees.Add(emp);
            }
        }

        // Display results from foreach loop
        Console.WriteLine("Employees named Joe (foreach loop):");
        foreach (Employee emp in joeEmployees)
        {
            Console.WriteLine(emp.FirstName + " " + emp.LastName);
        }

        // Create list of employees named "Joe" using lambda expression
        List<Employee> joeLambda = employees.Where(e => e.FirstName == "Joe").ToList();

        // Display results from lambda expression
        Console.WriteLine("\nEmployees named Joe (lambda):");
        foreach (Employee emp in joeLambda)
        {
            Console.WriteLine(emp.FirstName + " " + emp.LastName);
        }

        // Create list of employees with Id greater than 5 using lambda expression
        List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

        // Display results
        Console.WriteLine("\nEmployees with Id > 5:");
        foreach (Employee emp in idGreaterThanFive)
        {
            Console.WriteLine("ID: " + emp.Id + " - " + emp.FirstName + " " + emp.LastName);
        }

        // Keep console open
        Console.ReadLine();
    }
}
