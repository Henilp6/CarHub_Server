
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICarXFeatureRepository : IRepository<CarXFeature>
    {
        Task<CarXFeature> UpdateAsync(CarXFeature entity);
    }
}
