namespace EmployeesManagement.Models;

public class Employee : BaseModel
{
    public required string firstName { get; set; }
    public required string lastName { get; set; }
    public required string email { get; set; }
    public required string phone { get; set; }
    public required string position { get; set; }
}