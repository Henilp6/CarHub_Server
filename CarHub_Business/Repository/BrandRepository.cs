using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class BrandRepository: Repository<Brand>, IBrandRepository
    {
        private readonly ApplicationDbContext _db;
        public BrandRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Brand> UpdateAsync(Brand entity)
        {
            
            _db.Brands.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
