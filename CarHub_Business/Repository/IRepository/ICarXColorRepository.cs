
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICarXColorRepository : IRepository<CarXColor>
    {
        Task<CarXColor> UpdateAsync(CarXColor entity);
    }
}
