using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class FeatureRepository : Repository<Feature>, IFeatureRepository
    {
        private readonly ApplicationDbContext _db;
        public FeatureRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Feature> UpdateAsync(Feature entity)
        {
            
            _db.Features.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
