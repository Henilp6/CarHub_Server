

using CarHub_Models;

namespace CarHub_Client.Service.IService
{
    public interface IReviewXCommentService
    {
      
            Task<T> GetAllAsync<T>();
            Task<T> GetAsync<T>(int id);
            Task<T> CreateAsync<T>(ReviewXCommentCreateDTO dto, string token);
            Task<T> UpdateAsync<T>(ReviewXCommentUpdateDTO dto, string token);
            Task<T> DeleteAsync<T>(int id);
        
    }
}
