using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CarTypeRepository : Repository<CarType>, ICarTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CarTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<CarType> UpdateAsync(CarType entity)
        {

            _db.CarTypes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
