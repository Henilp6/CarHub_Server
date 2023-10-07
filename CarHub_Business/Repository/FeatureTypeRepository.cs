using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class FeatureTypeRepository : Repository<FeatureType>, IFeatureTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public FeatureTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<FeatureType> UpdateAsync(FeatureType entity)
        {
            
            _db.FeatureTypes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
