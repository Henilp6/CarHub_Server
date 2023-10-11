using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Client.Service.IService;

namespace CarHub_Client.Service
{
    public class ApplicationUserService : BaseService, IApplicationUserService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string carUrl;

        public ApplicationUserService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

        }

        //public Task<T> CreateAsync<T>(ApplicationUserCreateDTO dto, string token)
        //{
        //    return SendAsync<T>(new APIRequest()
        //    {
        //        ApiType = SD.ApiType.POST,
        //        Data = dto,
        //        Url = categoryUrl + "/api/v1/ApplicationUserAPI",
        //        Token = token
        //    });
        //}

        //public Task<T> DeleteAsync<T>(int id, string token)
        //{
        //    return SendAsync<T>(new APIRequest()
        //    {
        //        ApiType = SD.ApiType.DELETE,
        //        Url = categoryUrl + "/api/v1/ApplicationUserAPI/" + id,
        //        Token = token
        //    });
        //}

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = carUrl + "/api/v1/applicationUserAPI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(string Id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = carUrl + "/api/v1/applicationUserAPI/" + Id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(UserVM dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = carUrl + "/api/v1/ApplicationUserAPI",
                Token = token
            });
        }
    }
}
