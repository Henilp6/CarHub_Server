﻿

using CarHub_Models;

namespace CarHub_Client.Service.IService
{
    public interface IStateService
    {

        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(StateCreateDTO dto, string token);
        Task<T> UpdateAsync<T>(StateUpdateDTO dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);
        Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage,string token);

    }
}
