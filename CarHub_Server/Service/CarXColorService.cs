using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service
{
    public class CarXColorService : BaseService, ICarXColorService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string carUrl;

        public CarXColorService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

        }


		public Task<T> CreateAsync<T>(CarXColorCreateVM dto)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.POST,
				Data = dto,
				Url = carUrl + "/api/v1/CarXColorAPI/CreateCarXColor"
			});
		}

		public Task<T> DeleteAsync<T>(int id)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.DELETE,
				Url = carUrl + "/api/v1/CarXColorAPI/DeleteCarXColor/" + id
			});
		}

		public Task<T> GetAllAsync<T>()
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = carUrl + "/api/v1/CarXColorAPI/GetCarXColors"
			});
		}

		public Task<T> GetAsync<T>(int id)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = carUrl + "/api/v1/CarXColorAPI/GetCarXColor/" + id
			});
		}

		public Task<T> UpdateAsync<T>(CarXColorUpdateVM dto)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.PUT,
				Data = dto,
				Url = carUrl + "/api/v1/carXColorAPI/UpdateCarXColor"
			});
		}
	}
}



