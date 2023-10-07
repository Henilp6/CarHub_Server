using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private readonly ApplicationDbContext _db;
        public CountryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

  
        public async Task<Country> UpdateAsync(Country entity)
        {
         
            _db.Countries.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
