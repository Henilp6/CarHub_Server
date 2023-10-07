using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IStateRepository : IRepository<State>
    {
      
        Task<State> UpdateAsync(State entity);
  
    }
}
