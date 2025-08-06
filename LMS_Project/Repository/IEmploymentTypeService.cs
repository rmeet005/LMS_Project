using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IEmploymentTypeService
    {
        public void AddEmploymentType(EmploymentTypeDto employmentType);
        public List<EmploymentTypeDto> FetchAllEmploymentTypes();
        public void UpdateEmploymentType(EditEmploymentTypeDto employmentType);
        public void DeleteEmploymentType(int employmentTypeId);
    }
}
