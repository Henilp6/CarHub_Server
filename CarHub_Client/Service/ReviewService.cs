using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Client.Service.IService;

namespace CarHub_Client.Service
{
    public class ReviewService : BaseService, IReviewService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string carUrl;

        public ReviewService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

        }

        public Task<T> CreateAsync<T>(ReviewCreateVM dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = carUrl + "/api/v1/ReviewAPI",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = carUrl + "/api/v1/ReviewAPI/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = carUrl + "/api/v1/ReviewAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = carUrl + "/api/v1/ReviewAPI/" + id
            });
        }

        public Task<T> UpdateAsync<T>(ReviewUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = carUrl + "/api/v1/ReviewAPI/" + dto.Id,
                Token = token
            });
        }
    }
}
