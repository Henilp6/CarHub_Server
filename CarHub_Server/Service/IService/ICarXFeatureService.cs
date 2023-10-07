
using CarHub_Models.ViewModels;

namespace CarHub_Server.Service.IService{
	public interface ICarXFeatureService
	{

		Task<T> GetAllAsync<T>(string token);
		Task<T> GetAsync<T>(int id, string token);
		Task<T> CreateAsync<T>(CarXFeatureCreateVM dto, string token);
		Task<T> UpdateAsync<T>(CarXFeatureUpdateVM dto, string token);
		Task<T> DeleteAsync<T>(int id, string token);

	}}