
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICarTypeRepository : IRepository<CarType>
    {
        Task<CarType> UpdateAsync(CarType entity);
    }
}