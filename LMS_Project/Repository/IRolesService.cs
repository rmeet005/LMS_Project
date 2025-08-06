using LMS_Project.DTO;
using LMS_Project.Models;

namespace LMS_Project.Repository
{
    public interface IRolesService
    {
        public void AddRole(RolesDto role);
        public List<Roles> FetchAllRoles();
        public void UpdateRole(RolesDto role);
        public void DeleteRole(int RoleId);
    }
}
