using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string? Address { get; set; }

        [ForeignKey("Cities")]
        public int CityId { get; set; }
        public Cities Cities { get; set; }

        [ForeignKey("States")]
        public int StateId { get; set; }
        public States States { get; set; }

        [ForeignKey("Countries")]
        public int CountryId { get; set; }
        public Countries Countries { get; set; }

        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; }=false;
    }
}
