using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        private readonly ApplicationDbContext _db;
        public CityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

  
        public async Task<City> UpdateAsync(City entity)
        {
         
            _db.Cities.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
