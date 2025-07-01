using System.ComponentModel.DataAnnotations;
namespace EmployeesManagement.Models;

public class Employee : BaseModel
{
    [Required(ErrorMessage = "First name is required")]
    [MaxLength(30, ErrorMessage = "Max length is 30")]
    [MinLength(3, ErrorMessage = "Min length is 3")]
    public required string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last name is required")]
    [MaxLength(30, ErrorMessage = "Max length is 30")]
    public required string LastName { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [MaxLength(30, ErrorMessage = "Max length is 30")]
    public required string Email { get; set; }
    
    [Required(ErrorMessage = "Phone number is required")]
    public required string PhoneNumber { get; set; }
    
    [Required(ErrorMessage = "Position is required")]
    public required string Position { get; set; }
}