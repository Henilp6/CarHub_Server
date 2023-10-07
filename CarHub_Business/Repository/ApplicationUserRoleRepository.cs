using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
	public class ApplicationUserRoleRepository : Repository<ApplicationUserRole>, IApplicationUserRoleRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRoleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ApplicationUserRole> UpdateAsync(ApplicationUserRole entity)
        {
           // _db.ApplicationUserRoles.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
