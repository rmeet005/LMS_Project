namespace LMS_Project.DTO
{
    public class GetBranchDTO
    {
        public int BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
