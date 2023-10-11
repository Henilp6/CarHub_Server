
using CarHub_Models;

namespace CarHub_Client.Service.IService
{
    public interface IFeatureTypeService
    {

        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(FeatureTypeCreateDTO dto);
        Task<T> UpdateAsync<T>(FeatureTypeUpdateDTO dto);
        Task<T> DeleteAsync<T>(int id);
        Task<T> FeatureTypeByPagination<T>(string term, string orderBy, int currentPage );

    }
}
