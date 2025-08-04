using System.ComponentModel.DataAnnotations;

namespace LMS_Project.Models
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public string BankCode { get; set; }
       
        public string BankName { get; set; }
        public string? IFSCCode { get; set; }
        public string? BranchName { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
