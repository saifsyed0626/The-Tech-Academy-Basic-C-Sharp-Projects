using System;

// Create Employee class
public class Employee
{
    // Property for employee ID
    public int Id { get; set; }

    // Property for first name
    public string FirstName { get; set; }

    // Property for last name
    public string LastName { get; set; }

    // Overload the == operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both are null, return true
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one is null and the other is not, return false
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare Id properties
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator (must be paired with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the opposite of ==
        return !(emp1 == emp2);
    }

    // Override Equals method (recommended when overloading ==)
    public override bool Equals(object obj)
    {
        // Check if object is Employee
        if (obj is Employee emp)
        {
            return this.Id == emp.Id;
        }
        return false;
    }

    // Override GetHashCode method (recommended with Equals)
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Create first Employee object
        Employee emp1 = new Employee();
        emp1.Id = 1;
        emp1.FirstName = "John";
        emp1.LastName = "Doe";

        // Create second Employee object
        Employee emp2 = new Employee();
        emp2.Id = 1; // Same ID to test equality
        emp2.FirstName = "Jane";
        emp2.LastName = "Smith";

        // Compare the two employees using overloaded ==
        bool areEqual = emp1 == emp2;

        // Display result
        Console.WriteLine("Are employees equal? " + areEqual);

        // Compare using != operator
        bool areNotEqual = emp1 != emp2;

        // Display result
        Console.WriteLine("Are employees not equal? " + areNotEqual);

        // Keep console open
        Console.ReadLine();
    }
}