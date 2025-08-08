namespace LMS_Project.DTO
{
    public class GetPincodesDTO
    {
        public int PincodeId { get; set; }
        public string Pincode { get; set; }
        public string Area { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
