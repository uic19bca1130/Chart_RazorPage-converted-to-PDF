using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chart_RazorP.Models;

public class Employee
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string? Address { get; set; }
    [Required]
    public int Salary { get; set; }
    [NotMapped]
    public IFormFile File { get; set; }

}

