using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Deneme.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options) { }
        DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { EmployeeId = 1, Name = "Osman", Designation = "Developer", Address = "Ankara", CompanyName = "Mizmer" },
                new Employee() { EmployeeId = 2, Name = "Furkan", Designation = "Avukat", Address = "Kayseri", CompanyName = "Baro" }
            );
        }
    }
}
