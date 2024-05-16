using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

[Table("course")]
public class Course
{
    public Guid CourseId { get; set; }

    [Required(ErrorMessage = "Course name is required")]
    [StringLength(100, ErrorMessage = "Course name can't be longer than 100 characters")]
    public string? CourseName { get; set; }

    [Required(ErrorMessage = "Credits is required")]
    public int Credits { get; set; }

    [ForeignKey(nameof(Teacher))] public Guid TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
}