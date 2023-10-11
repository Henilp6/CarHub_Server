using CarHub_Models;
using CarHub_Models.ViewModels;

namespace CarHub_Server.Service.IService
{
    public interface IMileageService
    {
      
            Task<T> GetAllAsync<T>();
            Task<T> GetAsync<T>(int id);
            Task<T> CreateAsync<T>(MileageCreateVM dto);
            Task<T> UpdateAsync<T>(MileageUpdateVM dto);
            Task<T> DeleteAsync<T>(int id);
        Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage);

    }
}
