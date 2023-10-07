using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IFeatureTypeRepository : IRepository<FeatureType>
    {
        Task<FeatureType> UpdateAsync(FeatureType entity);
    }
}
