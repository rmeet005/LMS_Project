using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class OccupationTypeService: IOccupationTypeService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public OccupationTypeService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddOccupationType(OccupationTypeDto occupationTypeDto)
        {
            var occupationType = mapper.Map<OccupationType>(occupationTypeDto);
            db.OccupationTypes.Add(occupationType);
            db.SaveChanges();
        }
        public List<DTO.OccupationTypeDto> FetchAllOccupationTypes()
        {
            var data = db.OccupationTypes.ToList();
            return mapper.Map<List<OccupationTypeDto>>(data);
        }
    }
}
