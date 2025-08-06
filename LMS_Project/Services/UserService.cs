using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LMS_Project.Services
{
    public class UserService : IUserService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public UserService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddUser(UserDto user)
        {
            var d = mapper.Map<Users>(user);
            db.Users.Add(d);
            db.SaveChanges();
        }

        public List<Users> FetchAllUsers()
        {
            return db.Users.ToList();
        }
        public void UpdateUser(EditUserDto user)
        {
            var d=mapper.Map<Users>(user);
            db.Users.Update(d);
            db.SaveChanges();
        }

    }
}
