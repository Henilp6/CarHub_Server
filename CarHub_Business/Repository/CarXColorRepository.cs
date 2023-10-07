using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CarXColorRepository : Repository<CarXColor>, ICarXColorRepository
    {
        private readonly ApplicationDbContext _db;
        public CarXColorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<CarXColor> UpdateAsync(CarXColor entity)
        {
            
            _db.CarXColors.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
