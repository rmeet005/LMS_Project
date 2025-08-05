using System.ComponentModel.DataAnnotations;

namespace LMS_Project.DTO
{
    public class CountryDto
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
