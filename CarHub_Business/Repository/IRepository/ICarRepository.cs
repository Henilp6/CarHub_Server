
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICarRepository : IRepository<Car>
    {
        Task<Car> UpdateAsync(Car entity);
    }
}
