using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class EmploymentTypeService : IEmploymentTypeService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public EmploymentTypeService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddEmploymentType(EmploymentTypeDto employmentType)
        {
            var data = mapper.Map<EmploymentType>(employmentType);
            db.EmploymentTypes.Add(data);
            db.SaveChanges();
        }
        public List<EmploymentTypeDto> FetchAllEmploymentTypes()
        {
            var data = db.EmploymentTypes.Where(x=>x.IsDeleted==false).ToList();
            return mapper.Map<List<EmploymentTypeDto>>(data);
        }
        public void UpdateEmploymentType(EditEmploymentTypeDto employmentType)
        {
            var data = mapper.Map<EmploymentType>(employmentType);
            db.EmploymentTypes.Update(data);
            db.SaveChanges();
        }
        public void DeleteEmploymentType(int employmentTypeId)
        {
            var employmentType = db.EmploymentTypes.Find(employmentTypeId);
            if (employmentType != null)
            {
             employmentType.IsDeleted = true;
                db.SaveChanges();
            }
        }
    }
}
