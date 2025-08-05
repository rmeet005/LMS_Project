using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class PincodesService: IPincodesService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public PincodesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddPincode(PinCodesDto pincode)
        {
            var data = mapper.Map<Pincodes>(pincode);
            db.Pincodes.Add(data);
            db.SaveChanges();
        }
        public List<PinCodesDto> FetchAllPincodes()
        {
            var data = db.Pincodes.ToList();
            return mapper.Map<List<PinCodesDto>>(data);
        }
    }
}
