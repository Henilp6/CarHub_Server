
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICarSpecificationRepository : IRepository<CarSpecification>
    {
        Task<CarSpecification> UpdateAsync(CarSpecification entity);
    }
}

