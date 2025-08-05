using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IPincodesService
    {
        public void AddPincode(PinCodesDto pincode);
        public List<PinCodesDto> FetchAllPincodes();

    }
}
