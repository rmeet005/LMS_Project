using System.ComponentModel.DataAnnotations;

namespace LMS_Project.Models
{
    public class OccupationType
    {
        [Key]
        public int OccupationTypeId { get; set; }
        public string OccupationCode { get; set; }
        public string OccupationName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
