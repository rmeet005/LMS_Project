using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class RejectionReasonService : IRejectionReasonService
    {
        ApplicationDbContext db;
        IMapper mapper;
    public RejectionReasonService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddRejectionReason(RejectionReasonDto rejectionReason)
        {
            var data = mapper.Map<RejectionReason>(rejectionReason);
            db.RejectionReasons.Add(data);
            db.SaveChanges();
        }
        public List<RejectionReasonDto> FetchAllRejectionReasons()
        {
            var data = db.RejectionReasons.ToList();
            return mapper.Map<List<RejectionReasonDto>>(data);
        }
    }
}
