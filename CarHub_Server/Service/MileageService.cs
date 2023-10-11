using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class MileageService : BaseService, IMileageService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public MileageService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");        }        public Task<T> CreateAsync<T>(MileageCreateVM dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/MileageAPI/CreateMileage",                      });        }        public Task<T> DeleteAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/MileageAPI/DeleteMileage/" + id,                            });        }        public Task<T> GetAllAsync<T>()        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/MileageAPI/GetMileages",                       });        }        public Task<T> GetAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/MileageAPI/GetMileage/" + id,                         });        }        public Task<T> UpdateAsync<T>(MileageUpdateVM dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/MileageAPI/UpdateMileage/",                           });        }        public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage)
        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/MileageAPI/MileageByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = apiUrl,
           
            });

        }    }}
