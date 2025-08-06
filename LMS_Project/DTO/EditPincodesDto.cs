namespace LMS_Project.DTO
{
    public class EditPincodesDto
    {
        public int PincodeId { get; set; }
        public string Pincode { get; set; }
        public string? Area { get; set; }


        public int CityId { get; set; }



        public int StateId { get; set; }


        public int CountryId { get; set; }

        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
