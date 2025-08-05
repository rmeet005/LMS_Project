using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class EmploymentTypeService: IEmploymentTypeService
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
            var data = db.EmploymentTypes.ToList();
            return mapper.Map<List<EmploymentTypeDto>>(data);
        }
    }
}
