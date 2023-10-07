using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class CountryService : BaseService, ICountryService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public CountryService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;
			carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}        public Task<T> CreateAsync<T>(CountryCreateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/CountryAPI/CreateCountry",                            });        }        public Task<T> DeleteAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/CountryAPI/DeleteCountry/" + id,                           });        }        public Task<T> GetAllAsync<T>()        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/CountryAPI/GetCountrys"                          });        }
        public Task<T> GetCountryData<T>(int pageNum, string token)        {
            string apiUrl = $"{carUrl}/api/v1/CountryAPI/GetCountryData?pageNum={pageNum}";            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = apiUrl,                Token = token            });

        }        public Task<T> GetAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/CountryAPI/GetCountry/" + id                          });        }        public Task<T> UpdateAsync<T>(CountryUpdateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/CountryAPI/UpdateCountry/" + dto.Id                          });        }
        public Task<T> CountryByPagination<T>(string term, string orderBy, int currentPage)
        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/CountryAPI/CountryByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = apiUrl
               
            });

        }    }}
