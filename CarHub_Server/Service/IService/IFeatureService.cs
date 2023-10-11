using CarHub_Models;

namespace CarHub_Server.Service.IService
{
    public interface IFeatureService
    {
      
            Task<T> GetAllAsync<T>();
            Task<T> GetAsync<T>(int id);
            Task<T> CreateAsync<T>(FeatureCreateDTO dto);
            Task<T> UpdateAsync<T>(FeatureUpdateDTO dto);
            Task<T> DeleteAsync<T>(int id);
		Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage);

	}
}
