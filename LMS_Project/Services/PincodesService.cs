using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;
using Microsoft.EntityFrameworkCore;

namespace LMS_Project.Services
{
    public class PincodesService : IPincodesService
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
        public List<GetPincodesDTO> FetchAllPincodes()
        {
            var data = db.Pincodes.Where(p=>p.IsDeleted==false).Include(x=>x.Cities).Include(z=>z.States).Include(y=>y.Countries).ToList();
            return mapper.Map<List<GetPincodesDTO>>(data);
        }
        public void UpdatePincode(EditPincodesDto pincode)
        {
            var data = mapper.Map<Pincodes>(pincode);
            db.Pincodes.Update(data);
            db.SaveChanges();
        }
        public void DeletePincode(int pincodeId)
        {
            var pincode = db.Pincodes.Find(pincodeId);
            if (pincode != null)
            {
                pincode.IsDeleted = true;
                db.SaveChanges();
            }

        }
    }
}
