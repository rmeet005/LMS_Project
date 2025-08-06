namespace LMS_Project.DTO
{
    public class EditEmploymentTypeDto
    {
        public int EmploymentTypeId { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
