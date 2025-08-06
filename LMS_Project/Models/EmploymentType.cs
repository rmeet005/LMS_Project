using System.ComponentModel.DataAnnotations;

namespace LMS_Project.Models
{
    public class EmploymentType
    {
        [Key]
        public int EmploymentTypeId { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
