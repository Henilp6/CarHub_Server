
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IFeatureXFeaturetypeRepository : IRepository<FeatureXFeaturetype>
    {
        Task<FeatureXFeaturetype> UpdateAsync(FeatureXFeaturetype entity);
    }
}
