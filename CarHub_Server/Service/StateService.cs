using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class StateService : BaseService, IStateService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public StateService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;
			carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}        public Task<T> CreateAsync<T>(StateCreateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/StateAPI/CreateState",                            });        }        public Task<T> DeleteAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/StateAPI/DeleteState/" + id,                           });        }        public Task<T> GetAllAsync<T>()        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/StateAPI/GetStates",                           });        }        public Task<T> GetAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/StateAPI/GetState/" + id,                           });        }        public Task<T> UpdateAsync<T>(StateUpdateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/StateAPI/UpdateState/" + dto.Id,                            });        }
        public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage)        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData?term={term}&orderBy={orderBy}&currentPage={currentPage}";            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = apiUrl,                           });
                }     
    }}