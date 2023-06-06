using IT_Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace IT_Lab2.Contexts
{
    public class StudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }

        public StudentContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                "Server=LAPTOP-9JV1ERP4\\SQLEXPRESS;Database=StudentsDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
        }
    }
}
