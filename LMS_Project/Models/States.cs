using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.Models
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }

        [ForeignKey("Countries")]
        public int CountryId { get; set; }
        public Countries Countries { get; set; }
        public bool IsActive { get; set; }

        public List<Cities> Cities { get; set; }
        public List<Pincodes> Pincodes { get; set; }
    }
}
