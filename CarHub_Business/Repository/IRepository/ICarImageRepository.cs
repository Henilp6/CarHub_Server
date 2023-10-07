
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICarImageRepository : IRepository<CarImage>
    {
        Task<CarImage> UpdateAsync(CarImage entity);
    }
}
