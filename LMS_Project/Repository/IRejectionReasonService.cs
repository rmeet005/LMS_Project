using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IRejectionReasonService
    {
        public void AddRejectionReason(RejectionReasonDto rejectionReason);
        public List<RejectionReasonDto> FetchAllRejectionReasons();
    }
}
