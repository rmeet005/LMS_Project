namespace LMS_Project.DTO
{
    public class DocumentTypeDto
    {
        public int DocumentTypeId { get; set; }
        public string DocumentCode { get; set; }
        public string DocumentName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
