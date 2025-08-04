using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace LMS_Project.Models
{
    public class Users
    {
        [Key]
        public int Uid { get; set; }
        public string? UserName { get; set; }
        public String? Email { get; set; }
        public string? PasswordHash { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }

        public List<UserRoles>userroles{ get; set; } 

    }
}
