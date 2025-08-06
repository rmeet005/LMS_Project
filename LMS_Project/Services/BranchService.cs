using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class BranchService : IBranchService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public BranchService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddBranch(BranchDto branchDto)
        {
            var branch = mapper.Map<Branch>(branchDto);
            db.Branches.Add(branch);
            db.SaveChanges();
        }
        public List<BranchDto> FetchAllBranches()
        {
            var data = db.Branches.ToList();
            return mapper.Map<List<BranchDto>>(data);
        }
        public void UpdateBranch(EditBranchDto branchDto)
        {
            var branch = mapper.Map<Branch>(branchDto);
            db.Branches.Update(branch);
            db.SaveChanges();
        }
        public void DeleteBranch(int branchId)
        {
            var branch = db.Branches.Find(branchId);
            if (branch != null)
            {
                db.Branches.Remove(branch);
                db.SaveChanges();
            }
        }
    }
}
