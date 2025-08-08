using System.ComponentModel.DataAnnotations;

namespace LMS_Project.Models
{
    public class Countries
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public List<States> States { get; set; }
        public List<Pincodes> Pincodes { get; set; }
        public List<Branch> Branches { get; set; }
    }
}
