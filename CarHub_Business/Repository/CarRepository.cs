using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CarRepository: Repository<Car>, ICarRepository
    {
        private readonly ApplicationDbContext _db;
        public CarRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Car> UpdateAsync(Car entity)
        {
            
            _db.Cars.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
