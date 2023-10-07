using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class CarSpecificationRepository : Repository<CarSpecification>, ICarSpecificationRepository
    {
        private readonly ApplicationDbContext _db;
        public CarSpecificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<CarSpecification> UpdateAsync(CarSpecification entity)
        {
            
            _db.CarSpecifications.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
