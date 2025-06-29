namespace EmployeesManagement.Models;

public class Employee : BaseModel
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Position { get; set; }
}