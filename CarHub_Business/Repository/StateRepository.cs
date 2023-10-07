using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        private readonly ApplicationDbContext _db;
        public StateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

  
        public async Task<State> UpdateAsync(State entity)
        {
         
            _db.States.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
