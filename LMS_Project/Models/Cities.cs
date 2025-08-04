using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.Models
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        [ForeignKey("States")]
        public int StateId { get; set; }
        public States States { get; set; }
        public bool IsActive { get; set; }
        public List<Pincodes> Pincodes { get; set; }
    }
}
