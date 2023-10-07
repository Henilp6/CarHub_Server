using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
	public interface IApplicationRoleRepository : IRepository<ApplicationRole>
    {
        Task<ApplicationRole> UpdateAsync(ApplicationRole entity);
    }
}

