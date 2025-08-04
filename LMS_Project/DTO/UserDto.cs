namespace LMS_Project.DTO
{
    public class UserDto
    {
        public int Uid { get; set; }
        public string? UserName { get; set; }
        public String? Email { get; set; }
        public string? PasswordHash { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
