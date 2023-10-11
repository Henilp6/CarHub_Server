using CarHub_Models;
using CarHub_Models.ViewModels;

namespace CarHub_Client.Service.IService
{
    public interface IMileageService
    {
      
            Task<T> GetAllAsync<T>();
            Task<T> GetAsync<T>(int id);
            Task<T> CreateAsync<T>(MileageCreateVM dto, string token);
            Task<T> UpdateAsync<T>(MileageUpdateVM dto, string token);
            Task<T> DeleteAsync<T>(int id, string token);
        Task<T> MileageByPagination<T>(string term, string orderBy, int currentPage, string token);

    }
}
