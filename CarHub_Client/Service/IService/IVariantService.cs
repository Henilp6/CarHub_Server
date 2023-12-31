﻿
using CarHub_Models;
using CarHub_Models.ViewModels;

namespace CarHub_Client.Service.IService
{
    public interface IVariantService
    {
      
            Task<T> GetAllAsync<T>(string token);
            Task<T> GetAsync<T>(int id, string token);
            Task<T> CreateAsync<T>(VariantCreateVM dto, string token);
            Task<T> UpdateAsync<T>(VariantUpdateDTO dto, string token);
            Task<T> DeleteAsync<T>(int id, string token);
		Task<T> VariantByPagination<T>(string term, string orderBy, int currentPage, string token);

	}
}
