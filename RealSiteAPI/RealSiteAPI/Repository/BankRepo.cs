using RealSite.DBProvider;
using RealSite.DBProvider.Model;

namespace RealSiteAPI.Repository
{

    public class BankRepo : IBank
    {

        private readonly AppDbContext _appDbContext;

        public BankRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Bank addBank(Bank Bank)
        {
            throw new NotImplementedException();
        }

        public Bank deleteBank(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bank> GetAll()
        {
            List<Bank> ee = _appDbContext.Bank_list.ToList(); //.employee_list.
            return ee;
        }
        public Bank GetBank(int id)
        {
            throw new NotImplementedException();
        }

        public Bank updateBank(Bank Bank)
        {
            throw new NotImplementedException();
        }
    }
}
