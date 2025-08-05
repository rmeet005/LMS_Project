namespace LMS_Project.DTO
{
    public class OccupationTypeDto
    {
        public int OccupationTypeId { get; set; }
        public string OccupationCode { get; set; }
        public string OccupationName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
