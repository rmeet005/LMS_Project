using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IUserRolesService
    {
        public void AddUserRole(UserRoleDto userRole);
        public List<UserRoleDto> FetchAllUserRoles();
        public void UpdateUserRole(UserRoleDto userRole);
        public void DeleteUserRole(int userRoleId);
    }
}
