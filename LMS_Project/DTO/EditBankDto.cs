namespace LMS_Project.DTO
{
    public class EditBankDto
    {
        public int BankId { get; set; }
        public string BankCode { get; set; }

        public string BankName { get; set; }
        public string? IFSCCode { get; set; }
        public string? BranchName { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
