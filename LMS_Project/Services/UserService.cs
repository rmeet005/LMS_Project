using AutoMapper;
using LMS_Project.Data;

namespace LMS_Project.Services
{
    public class UserService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public UserService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddUser(Models.Users user)
        {
            mapper.Map<Models.Users>(user);
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
