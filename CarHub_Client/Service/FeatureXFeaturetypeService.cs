using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Client.Service.IService;

namespace CarHub_Client.Service
{
	public class FeatureXFeaturetypeService : BaseService, IFeatureXFeaturetypeService
	{
		private readonly IHttpClientFactory _clientFactory;
		private string carUrl;

		public FeatureXFeaturetypeService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
		{
			_clientFactory = clientFactory;
			carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}

		public Task<T> CreateAsync<T>(FeatureXFeaturetypeCreateVM dto, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.POST,
				Data = dto,
				Url = carUrl + "/api/v1/FeatureXFeaturetypeAPI/CreateFeatureXFeaturetype",
				Token = token
			});
		}

		public Task<T> DeleteAsync<T>(int id, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.DELETE,
				Url = carUrl + "/api/v1/FeatureXFeaturetypeAPI/DeleteFeatureXFeaturetype/" + id,
				Token = token
			});
		}

		public Task<T> GetAllAsync<T>()
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = carUrl + "/api/v1/FeatureXFeaturetypeAPI/GetFeatureXFeaturetypes"
			});
		}

		public Task<T> GetAsync<T>(int id, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = carUrl + "/api/v1/FeatureXFeaturetypeAPI/" + id,
				Token = token
			});
		}

		public Task<T> UpdateAsync<T>(FeatureXFeaturetypeUpdateVM dto, string token)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.PUT,
				Data = dto,
				Url = carUrl + "/api/v1/FeatureXFeaturetypeAPI/UpdateFeatureXFeaturetype",
				Token = token
			});
		}
		public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage, string token)
		{
			//string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
			string apiUrl = $"{carUrl}/api/v1/FeatureXFeaturetypeAPI/GetFeatureXFeaturetypeData?term={term}&orderBy={orderBy}&currentPage={currentPage}";

			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = apiUrl,
				Token = token
			});

		}
	}
}
