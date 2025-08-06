using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IBranchService
    {
        public void AddBranch(BranchDto branchDto);
        public List<BranchDto> FetchAllBranches();
        public void UpdateBranch(EditBranchDto branchDto);
        public void DeleteBranch(int BranchId);
        
    }
}
