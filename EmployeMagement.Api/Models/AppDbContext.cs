
using ClassLibrary1;
using Microsoft.EntityFrameworkCore;

namespace EmployeMagement.Api.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 4, DepartmentName = "Admin" });
            // Seed Employee Table
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmployeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",

                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/aa2.jpg"
            });
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmployeId = 2,
                FirstName = "ssest",
                LastName = "aallo",
                Email = "abgaaac@email.com",
                DateOfBirth = new DateTime(1998, 2, 1),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "image/aa2.jpg"

            });
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmployeId = 3,
                FirstName = "ssest",
                LastName = "aallo",
                Email = "abgaaac@email.com",
                DateOfBirth = new DateTime(1998, 2, 1),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "image/aa2.jpg"
            });
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmployeId = 4,
                FirstName = "ssest",
                LastName = "aallo",
                Email = "abgaaac@email.com",
                DateOfBirth = new DateTime(1998, 2, 1),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "image/aa2.jpg"
            });
        }

    }
}
