using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class FeatureTypeService : BaseService, IFeatureTypeService
	{        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public FeatureTypeService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");        }        public Task<T> CreateAsync<T>(FeatureTypeCreateDTO dto, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/FeatureTypeAPI/CreateFeatureType",                Token = token            });        }        public Task<T> DeleteAsync<T>(int id, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/FeatureTypeAPI/DeleteFeatureType/" + id,                Token = token            });        }        public Task<T> GetAllAsync<T>(string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/FeatureTypeAPI/GetFeatureTypes",                Token = token            });        }        public Task<T> GetAsync<T>(int id, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/FeatureTypeAPI/GetFeatureType/" + id,                Token = token            });        }        public Task<T> UpdateAsync<T>(FeatureTypeUpdateDTO dto, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/FeatureTypeAPI/UpdateFeatureType/" + dto.Id,                Token = token            });        }

        public Task<T> FeatureTypeByPagination<T>(string term, string orderBy, int currentPage, string token)
        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/FeatureTypeAPI/FeatureTypeByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = apiUrl,
                Token = token
            });

        }    }}
