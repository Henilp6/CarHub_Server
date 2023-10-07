using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class FeatureXFeaturetypeRepository : Repository<FeatureXFeaturetype>, IFeatureXFeaturetypeRepository
    {
        private readonly ApplicationDbContext _db;
        public FeatureXFeaturetypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<FeatureXFeaturetype> UpdateAsync(FeatureXFeaturetype entity)
        {
            
            _db.FeatureXFeaturetypes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
