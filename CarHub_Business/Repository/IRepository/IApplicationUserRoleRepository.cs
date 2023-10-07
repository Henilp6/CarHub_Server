using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
	public interface IApplicationUserRoleRepository : IRepository<ApplicationUserRole>
    {
        Task<ApplicationUserRole> UpdateAsync(ApplicationUserRole entity);
    }
}