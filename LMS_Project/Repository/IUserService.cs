using LMS_Project.DTO;
using LMS_Project.Models;

namespace LMS_Project.Repository
{
    public interface IUserService
    {
        void AddUser(UserDto user);
        public List<Users> FetchAllUsers();
    }
}
