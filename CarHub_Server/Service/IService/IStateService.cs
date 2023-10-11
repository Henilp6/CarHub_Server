

using CarHub_Models;

namespace CarHub_Server.Service.IService
{
    public interface IStateService
    {

        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(StateCreateDTO dto);
        Task<T> UpdateAsync<T>(StateUpdateDTO dto);
        Task<T> DeleteAsync<T>(int id);
        Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage);

    }
}
