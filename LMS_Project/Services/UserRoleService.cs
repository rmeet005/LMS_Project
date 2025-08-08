using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Services
{
    public class UserRoleService : IUserRolesService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public UserRoleService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddUserRole(UserRoleDto userRole)
        {
            var d = mapper.Map<UserRoles>(userRole);
            db.UserRoles.Add(d);
            db.SaveChanges();

        }
        public List<UserRoleDto> FetchAllUserRoles()
        {
            var data = db.UserRoles.Where(x => x.IsDeleted == false).ToList();
            return mapper.Map<List<UserRoleDto>>(data);
        }
        public void UpdateUserRole(UserRoleDto userRole)
        {
            var d = mapper.Map<UserRoles>(userRole);
            db.UserRoles.Update(d);
            db.SaveChanges();
        }
        public void DeleteUserRole(int userRoleId)
        {
            var userRole = db.UserRoles.Find(userRoleId);
            if (userRole != null)
            {
                userRole.IsDeleted = true;
                db.SaveChanges();
            }
        }
    }
}