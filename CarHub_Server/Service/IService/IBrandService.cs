using CarHub_Models;


namespace CarHub_Server.Service.IService
{
	public interface IBrandService
	{

		Task<T> GetAllAsync<T>();
		Task<T> GetAsync<T>(int id);
		Task<T> CreateAsync<T>(BrandCreateDTO dto);
		Task<T> UpdateAsync<T>(BrandUpdateDTO dto);
		Task<T> DeleteAsync<T>(int id);
		Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage);

	}
}
