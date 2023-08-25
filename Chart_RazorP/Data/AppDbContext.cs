using Chart_RazorP.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Chart_RazorP.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
    {

    }
    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var employee = builder.Entity<Employee>();
        employee.HasData(new Employee
        {
            Id=Guid.Parse(Guid.NewGuid().ToString()),
            Name="Sushant",
            Address="Chandigarh",
            Salary= 45000
        }, new Employee
        {
            Id = Guid.Parse(Guid.NewGuid().ToString()),
            Name = "Nikhil",
            Address = "Mohali",
            Salary = 50000
        },new Employee
        {
            Id = Guid.Parse(Guid.NewGuid().ToString()),
            Name = "Rohit",
            Address = "Chandigarh",
            Salary = 37000
        }, new Employee
        {
            Id = Guid.Parse(Guid.NewGuid().ToString()),
            Name = "Uvti",
            Address = "Chandigarh",
            Salary = 27000
        });
    }
}

