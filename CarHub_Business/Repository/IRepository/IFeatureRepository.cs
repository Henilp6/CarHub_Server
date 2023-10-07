
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IFeatureRepository : IRepository<Feature>
    {
        Task<Feature> UpdateAsync(Feature entity);
    }
}
