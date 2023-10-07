
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface ICountryRepository : IRepository<Country>
    {
      
        Task<Country> UpdateAsync(Country entity);
  
    }
}
