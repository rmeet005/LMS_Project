using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.Models
{
    public class Pincodes
    {
        [Key]
        public int PincodeId { get; set; }
        public string Pincode { get; set; }
        public string? Area { get; set; }

        [ForeignKey("Cities")]
        public int CityId { get; set; }
        public Cities Cities { get; set; }

        [ForeignKey("States")]
        public int StateId { get; set; }
        public States States { get; set; }

        [ForeignKey("Countries")]
        public int CountryId { get; set; }
        public Countries Countries { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
    }
}
