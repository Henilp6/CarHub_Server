using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
	public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser> UpdateAsync(ApplicationUser entity);
    }
}