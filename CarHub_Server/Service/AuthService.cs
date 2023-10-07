using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{
	public class AuthService : BaseService, IAuthService    {
		private readonly IHttpClientFactory _clientFactory;
		private string carUrl;

		public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
		{
			_clientFactory = clientFactory;
            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}

		public Task<T> LoginAsync<T>(LoginRequestDTO obj)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = obj,                Url = carUrl + "/api/v1/UsersAuth/login"            });        }        public Task<T> RegisterAsync<T>(RegisterationRequestDTO obj)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = obj,                Url = carUrl + "/api/v1/UsersAuth/register"            });        }    }}