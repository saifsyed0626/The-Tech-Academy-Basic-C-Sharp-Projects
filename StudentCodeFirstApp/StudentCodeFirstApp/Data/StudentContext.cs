using System.Data.Entity;
using StudentCodeFirstApp.Models;

namespace StudentCodeFirstApp.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDb")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
