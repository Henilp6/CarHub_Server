﻿

using CarHub_Models;

namespace CarHub_Server.Service.IService
{
    public interface IReviewXCommentService
    {
      
            Task<T> GetAllAsync<T>(string token);
            Task<T> GetAsync<T>(int id, string token);
            Task<T> CreateAsync<T>(ReviewXCommentCreateDTO dto, string token);
            Task<T> UpdateAsync<T>(ReviewXCommentUpdateDTO dto, string token);
            Task<T> DeleteAsync<T>(int id, string token);
        
    }
}
