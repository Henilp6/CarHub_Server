﻿

using CarHub_Models;

namespace CarHub_Server.Service.IService
{
    public interface IDealerService
	{
      
            Task<T> GetAllAsync<T>(string token);
            Task<T> GetAsync<T>(int id, string token);
            Task<T> CreateAsync<T>(DealerCreateDTO dto, string token);
            Task<T> UpdateAsync<T>(DealerUpdateDTO dto, string token);
            Task<T> DeleteAsync<T>(int id, string token);
        
    }
}
