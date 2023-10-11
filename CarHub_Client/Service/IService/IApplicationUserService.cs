using CarHub_Models;
using CarHub_Models.ViewModels;

namespace CarHub_Client.Service.IService
{
	public interface IApplicationUserService
    {
            Task<T> GetAllAsync<T>(string token);
            Task<T> GetAsync<T>(string Id, string token);
            Task<T> UpdateAsync<T>(UserVM dto, string token);
    }
}
