

using CarHub_Models;

namespace CarHub_Client.Service.IService
{
    public interface ICarTypeService
    {
      
            Task<T> GetAllAsync<T>();
            Task<T> GetAsync<T>(int id);
            Task<T> CreateAsync<T>(CarTypeCreateDTO dto);
            Task<T> UpdateAsync<T>(CarTypeUpdateDTO dto);
            Task<T> DeleteAsync<T>(int id);
           Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage);


    }
}
