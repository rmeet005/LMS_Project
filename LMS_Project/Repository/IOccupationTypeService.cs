using LMS_Project.DTO;
using LMS_Project.Models;

namespace LMS_Project.Repository
{
    public interface IOccupationTypeService
    {
        public void AddOccupationType(OccupationTypeDto occupationTypeDto);
        public List<OccupationTypeDto> FetchAllOccupationTypes();
    }
}
