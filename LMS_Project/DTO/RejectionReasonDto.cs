using System.ComponentModel.DataAnnotations;

namespace LMS_Project.DTO
{
    public class RejectionReasonDto
    {
        public int ReasonId { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonText { get; set; }
        public string? Category { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
