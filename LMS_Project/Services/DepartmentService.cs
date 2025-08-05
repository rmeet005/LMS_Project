using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class DepartmentService : IDepartmentService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public DepartmentService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddDepartment(DepartmentDto departmentDto)
        {
            var department = mapper.Map<Department>(departmentDto);
            db.Departments.Add(department);
            db.SaveChanges();
        }
        public List<DepartmentDto> FetchAllDepartments()
        {
            var data = db.Departments.ToList();
            return mapper.Map<List<DepartmentDto>>(data);

        }
    }
}
