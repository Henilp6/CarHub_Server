﻿using CarHub_Models.ViewModels;


namespace CarHub_Server.Service.IService
{
    public interface ICarImageService
    {

		Task<T> GetAllAsync<T>(string token);
		Task<T> GetAsync<T>(int id, string token);
		Task<T> CreateAsync<T>(CarImagesCreateVM dto, string token);
		Task<T> UpdateAsync<T>(CarImagesUpdateVM dto, string token);

        Task<T> SetAsync<T>(int imageId, int carId, string token);
        Task<T> DeleteAsync<T>(int id, string token);
	}
}
