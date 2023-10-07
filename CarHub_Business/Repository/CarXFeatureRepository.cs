using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CarXFeatureRepository : Repository<CarXFeature>, ICarXFeatureRepository
    {
        private readonly ApplicationDbContext _db;
        public CarXFeatureRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<CarXFeature> UpdateAsync(CarXFeature entity)
        {
            
            _db.CarXFeatures.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
