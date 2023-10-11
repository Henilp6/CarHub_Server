using CarHub_Models.ViewModels;


namespace CarHub_Server.Service.IService
{
    public interface ICarImageService
    {

		Task<T> GetAllAsync<T>();
		Task<T> GetAsync<T>(int id);
		Task<T> CreateAsync<T>(CarImagesCreateVM dto);
		Task<T> UpdateAsync<T>(CarImagesUpdateVM dto);

		Task<T> SetAsync<T>(int imageId, int carId);
		Task<T> DeleteAsync<T>(int id);
	}
}
