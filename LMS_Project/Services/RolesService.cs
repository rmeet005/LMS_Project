using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class RolesService : IRolesService
    {
        ApplicationDbContext db;
        IMapper mapper;

        public RolesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddRole(RolesDto roles)
        {
            var data = mapper.Map<Roles>(roles);
            db.Roles.Add(data);
            db.SaveChanges();
        }
        public List<Roles> FetchAllRoles()
        {
            var data= db.Roles.Where(x=>x.IsDeleted==false).ToList();
            return data;

        }
        public void UpdateRole(RolesDto role)
        {
            var d = mapper.Map<Roles>(role);
            db.Roles.Update(d);
            db.SaveChanges();
        }
        public void DeleteRole(int RoleId)
        {
            var role = db.Roles.Find(RoleId);
            if (role != null)
            {
                role.IsDeleted = true;
                db.SaveChanges();
            }
        }
    }
}
