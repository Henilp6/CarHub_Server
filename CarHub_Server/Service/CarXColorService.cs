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


		public Task<T> CreateAsync<T>(CarXColorCreateVM dto, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.POST,
				Data = dto,
				Url = carUrl + "/api/v1/CarXColorAPI/CreateCarXColor",
				Token = token
			});
		}

		public Task<T> DeleteAsync<T>(int id, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.DELETE,
				Url = carUrl + "/api/v1/CarXColorAPI/DeleteCarXColor/" + id,
				Token = token
			});
		}

		public Task<T> GetAllAsync<T>(string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = carUrl + "/api/v1/CarXColorAPI/GetCarXColors",
				Token = token
			});
		}

		public Task<T> GetAsync<T>(int id, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = carUrl + "/api/v1/CarXColorAPI/GetCarXColor/" + id,
				Token = token
			});
		}

		public Task<T> UpdateAsync<T>(CarXColorUpdateVM dto, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.PUT,
				Data = dto,
				Url = carUrl + "/api/v1/carXColorAPI/UpdateCarXColor",
				Token = token
			});
		}
	}
}



