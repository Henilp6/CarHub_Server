using CarHub_Models;
using CarHub_Models.ViewModels;

namespace CarHub_Server.Service.IService
{
    public interface IMileageService
    {
      
            Task<T> GetAllAsync<T>(string token);
            Task<T> GetAsync<T>(int id, string token);
            Task<T> CreateAsync<T>(MileageCreateVM dto, string token);
            Task<T> UpdateAsync<T>(MileageUpdateVM dto, string token);
            Task<T> DeleteAsync<T>(int id, string token);
        Task<T> MileageByPagination<T>(string term, string orderBy, int currentPage, string token);

    }
}
