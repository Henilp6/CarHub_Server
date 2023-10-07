
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IBrandRepository: IRepository<Brand>
    {
        Task<Brand> UpdateAsync(Brand entity);
    }
}
