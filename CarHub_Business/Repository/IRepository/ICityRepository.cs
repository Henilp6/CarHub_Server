
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICityRepository : IRepository<City>
    {
      
        Task<City> UpdateAsync(City entity);
  
    }
}
