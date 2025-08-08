using System.ComponentModel.DataAnnotations;

namespace LMS_Project.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; } = false;

        public List<UserRoles> userroles { get; set; }


    }
}
