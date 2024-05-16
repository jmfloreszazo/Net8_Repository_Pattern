using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

[Table("teacher")]
public class Teacher
{
    public Guid TeacherId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Expertise field is required")]
    public string? Expertise { get; set; }

    public ICollection<Course>? Courses { get; set; }
}