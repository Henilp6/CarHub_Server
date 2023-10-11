using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Client.Service.IService;

namespace CarHub_Client.Service{    public class BrandService : BaseService, IBrandService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public BrandService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");        }        //public Task<T> CreateAsync<T>(BrandCreateDTO dto)        //{        //    return SendAsync<T>(new APIRequest()        //    {        //        ApiType = SD.ApiType.POST,        //        Data = dto,        //        Url = carUrl + "/api/v1/BrandAPI/CreateBrand"        //    });        //}
        public Task<T> CreateAsync<T>(BrandCreateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/BrandAPI/CreateBrand"

            });        }        public Task<T> DeleteAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/BrandAPI/DeleteBrand/" + id                           });        }        public Task<T> GetAllAsync<T>()        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/BrandAPI/GetBrands"                          });        }        public Task<T> GetAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/BrandAPI/GetBrand/" + id                         });        }        public Task<T> UpdateAsync<T>(BrandUpdateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/BrandAPI/UpdateBrand/" + dto.Id                      });        }
		public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage)
		{
			//string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
			string apiUrl = $"{carUrl}/api/v1/BrandAPI/GetBrandIndex?term={term}&orderBy={orderBy}&currentPage={currentPage}";

			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = apiUrl
			});

		}
	}}
