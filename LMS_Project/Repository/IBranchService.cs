using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IBranchService
    {
        public void AddBranch(BranchDto branchDto);
        public List<BranchDto> FetchAllBranches();
    }
}
