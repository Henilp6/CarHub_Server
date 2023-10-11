using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class CarImageService : BaseService, ICarImageService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public CarImageService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");        }        public Task<T> CreateAsync<T>(CarImagesCreateVM dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/CarImageAPI/CreateCarImage",                           });        }        public Task<T> DeleteAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/CarImageAPI/DeleteCarImage" + id,                           });        }        public Task<T> GetAllAsync<T>()        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/CarImageAPI/GetCarImages",                         });        }        public Task<T> GetAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/CarImageAPI/GetCarImage" + id,                           });        }        public Task<T> UpdateAsync<T>(CarImagesUpdateVM dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/CarImageAPI",                          });        }
        public Task<T> SetAsync<T>(int imageId, int carId)
        {
            string apiUrl = $"{carUrl}/api/v1/CarImageAPI/{imageId}/{carId}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                // Data = dto,
                Url = apiUrl,
               
            });
        }    }}
