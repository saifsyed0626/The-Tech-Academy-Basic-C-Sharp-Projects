using System;
using StudentCodeFirstApp.Data;
using StudentCodeFirstApp.Models;

namespace StudentCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
