using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.Models
{
    public class UserRoles
    {
        [Key]
        public int UserRoleId { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }

        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public Roles Roles { get; set; }

        public DateTime AssignedAt { get; set; } 

    }
}
