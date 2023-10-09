using CarHub_Models;

namespace CarHub_Server.Service.IService
{
    public interface ICarService
    {
      
            Task<T> GetAllAsync<T>();
            Task<T> GetAsync<T>(int id);
            Task<T> CreateAsync<T>(CarCreateDTO dto);
            Task<T> UpdateAsync<T>(CarUpdateDTO dto);
            Task<T> DeleteAsync<T>(int id);
        Task<T> CarSearchByLazyLoading<T>(int pageNum, string searchText);
		Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage);

	}
}
