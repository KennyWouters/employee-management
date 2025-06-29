using EmployeesManagement.Data;
using EmployeesManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace EmployeesManagement.Repositories;

public class EmployeesRepository(AppDbContext context) :  IEmployeesRepository
{
    public async Task<IEnumerable<Employee>> GetEmployeesAsync()
    {
        return await context.Employees.ToListAsync();
    }

    public async Task<Employee?> GetEmployeeAsync(int id)
    {
        return await context.Employees.FindAsync(id);
    }

    public async Task CreateEmployeeAsync(Employee employee)
    {
        await context.Employees.AddAsync(employee);
        await context.SaveChangesAsync();
    }

    public Task UpdateEmployeeAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployeeAsync(int id)
    {
        throw new NotImplementedException();
    }
}