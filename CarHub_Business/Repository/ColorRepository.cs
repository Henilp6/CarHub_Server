using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class ColorRepository: Repository<Color>, IColorRepository
    {
        private readonly ApplicationDbContext _db;
        public ColorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Color> UpdateAsync(Color entity)
        {
            
            _db.Colors.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
