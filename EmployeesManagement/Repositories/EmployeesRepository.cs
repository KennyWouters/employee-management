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

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        context.Employees.Update(employee);
        await context.SaveChangesAsync();
    }

    public async Task DeleteEmployeeAsync(int id)
    {
        var employeeInDb = await context.Employees.FindAsync(id);
        if (employeeInDb == null)
        {
            throw new KeyNotFoundException($"Employee with id {id} not found");
        }
        context.Employees.Remove(employeeInDb);
        await context.SaveChangesAsync();
    }
}