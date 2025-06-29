using EmployeesManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagement.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext
{
    public DbSet<Employee> employees;
}