
using CarHub_Models.ViewModels;

namespace CarHub_Client.Service.IService{
	public interface ICarXFeatureService
	{

		Task<T> GetAllAsync<T>();
		Task<T> GetAsync<T>(int id, string token);
		Task<T> CreateAsync<T>(CarXFeatureCreateVM dto, string token);
		Task<T> UpdateAsync<T>(CarXFeatureUpdateVM dto, string token);
		Task<T> DeleteAsync<T>(int id, string token);

	}}