using EmployeesManagement.Data;
using EmployeesManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace EmployeesManagement.Repositories;

public class EmployeesRepository(AppDbContext context) :  IEmployeesRepository
{
    public async Task<IEnumerable<Employee>> GetEmployeesAsync()
    {
        return await context.employees.ToListAsync();
    }

    public async Task<Employee?> GetEmployeeAsync(int id)
    {
        return await context.employees.FindAsync(id);
    }

    public async Task CreateEmployeeAsync(Employee employee)
    {
        await context.employees.AddAsync(employee);
        await context.SaveChangesAsync();
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployeeAsync(int id)
    {
        throw new NotImplementedException();
    }
}