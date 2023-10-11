
using CarHub_Models;
using CarHub_Models.ViewModels;

namespace CarHub_Client.Service.IService{
	public interface IFeatureXFeaturetypeService
    {

		Task<T> GetAllAsync<T>();
		Task<T> GetAsync<T>(int id, string token);
		Task<T> CreateAsync<T>(FeatureXFeaturetypeCreateVM dto, string token);
		Task<T> UpdateAsync<T>(FeatureXFeaturetypeUpdateVM dto, string token);
		Task<T> DeleteAsync<T>(int id, string token);
		Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage, string token);

	}}