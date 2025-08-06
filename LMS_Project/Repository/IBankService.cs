using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IBankService
    {
        public void AddBank(BankDto bank);
        public List<BankDto> FetchAllBanks();
        public void UpdateBank(EditBankDto bank);
        public void DeleteBank(int bankId);
    }
}
