using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class ApplicationUserRoleService : BaseService, IApplicationUserRoleService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public ApplicationUserRoleService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");        }

        public Task<T> GetAllAsync<T>(string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/applicationUserRoleAPI",                Token = token            });        }        public Task<T> GetAsync<T>(string Id, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/applicationUserRoleAPI/" + Id,                Token = token            });        }


    }}