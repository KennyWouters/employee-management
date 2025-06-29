using EmployeesManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagement.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
}