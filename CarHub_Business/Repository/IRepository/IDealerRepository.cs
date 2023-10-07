
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IDealerRepository : IRepository<Dealer>
    {
        Task<Dealer> UpdateAsync(Dealer entity);
    }
}
