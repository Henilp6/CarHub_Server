using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CarImageRepository : Repository<CarImage>, ICarImageRepository
    {
        private readonly ApplicationDbContext _db;
        public CarImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<CarImage> UpdateAsync(CarImage entity)
        {
            
            _db.CarImages.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
