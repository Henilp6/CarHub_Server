using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        private readonly ApplicationDbContext _db;
        public ReviewRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Review> UpdateAsync(Review entity)
        {
            
            _db.Reviews.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
