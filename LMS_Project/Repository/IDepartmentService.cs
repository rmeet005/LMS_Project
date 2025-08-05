using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IDepartmentService
    {
        public void AddDepartment(DepartmentDto departmentDto);
        public List<DepartmentDto> FetchAllDepartments();
    }
}
