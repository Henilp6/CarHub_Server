

using CarHub_Models;

namespace CarHub_Server.Service.IService
{
    public interface ICountryService
    {

        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(CountryCreateDTO dto);
        Task<T> UpdateAsync<T>(CountryUpdateDTO dto);
        Task<T> DeleteAsync<T>(int id);
        Task<T> GetCountryData<T>(int pageNum, string token);
        Task<T> CountryByPagination<T>(string term, string orderBy, int currentPage);


    }
}
