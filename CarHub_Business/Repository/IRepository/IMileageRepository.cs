using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IMileageRepository : IRepository<Mileage>
    {
        Task<Mileage> UpdateAsync(Mileage entity);
    }
}
