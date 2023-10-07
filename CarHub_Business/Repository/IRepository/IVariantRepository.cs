using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IVariantRepository : IRepository<Variant>
    {
        Task<Variant> UpdateAsync(Variant entity);
    }
}
