using EmployeesManagement.Models;
using EmployeesManagement.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController(IEmployeesRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Employee>> GetEmployeesAsync()
    {
        return await repository.GetEmployeesAsync();
    }

    [HttpGet("{id}", Name = "GetEmployee")]
    public async Task<ActionResult<Employee>> GetEmployeeAsync(int id)
    {
       var employee =  await repository.GetEmployeeAsync(id);
       if (employee == null) return NotFound();
       return Ok(employee);
    }

    [HttpPost]
    public async Task<ActionResult<Employee>> CreateEmployeeAsync(Employee employee)
    {
        await repository.CreateEmployeeAsync(employee);
        return CreatedAtRoute("GetEmployee", new { id = employee.Id }, employee);
    }
}