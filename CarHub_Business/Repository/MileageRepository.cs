using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{


    public class MileageRepository : Repository<Mileage>, IMileageRepository
    {
        private readonly ApplicationDbContext _db;
        public MileageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Mileage> UpdateAsync(Mileage entity)
        {

            _db.Mileages.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
