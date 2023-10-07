using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class VariantRepository : Repository<Variant>, IVariantRepository
    {
        private readonly ApplicationDbContext _db;
        public VariantRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Variant> UpdateAsync(Variant entity)
        {
            
            _db.Variants.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
