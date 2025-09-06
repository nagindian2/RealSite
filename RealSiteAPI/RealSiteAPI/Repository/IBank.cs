using RealSite.DBProvider.Model;

namespace RealSiteAPI.Repository
{
    public interface IBank
    {
        Bank GetBank(int id);
        IEnumerable<Bank> GetAll();
        Bank addBank(Bank Bank);
        Bank updateBank(Bank Bank);
        Bank deleteBank(int id);
    }
}
