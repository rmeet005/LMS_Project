using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class BankService: IBankService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public BankService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddBank(BankDto bank)
        {
            var data = mapper.Map<Models.Bank>(bank);
            db.Banks.Add(data);
            db.SaveChanges();
        }
        public List<BankDto> FetchAllBanks()
        {
            var data = db.Banks.Where(x => x.IsDeleted == false).ToList();
            return mapper.Map<List<BankDto>>(data);
        }
        public void UpdateBank(EditBankDto bank)
        {
            var data = mapper.Map<Models.Bank>(bank);
            db.Banks.Update(data);
            db.SaveChanges();
        }
        public void DeleteBank(int bankId)
        {
            var bank = db.Banks.Find(bankId);
            if (bank != null)
            {
                bank.IsDeleted = true;
                db.SaveChanges();
            }
        }
    }
}
