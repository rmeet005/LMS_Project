using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IPincodesService
    {
        public void AddPincode(PinCodesDto pincode);
        public List<GetPincodesDTO> FetchAllPincodes();
        public void UpdatePincode(EditPincodesDto pincode);
        public void DeletePincode(int pincodeId);

    }
}
