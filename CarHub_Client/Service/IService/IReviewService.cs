


using CarHub_Models;
using CarHub_Models.ViewModels;

namespace CarHub_Client.Service.IService
{
    public interface IReviewService
    {
      
            Task<T> GetAllAsync<T>();
            Task<T> GetAsync<T>(int id);
            Task<T> CreateAsync<T>(ReviewCreateVM dto, string token);
            Task<T> UpdateAsync<T>(ReviewUpdateDTO dto, string token);
            Task<T> DeleteAsync<T>(int id);
        
    }
}
