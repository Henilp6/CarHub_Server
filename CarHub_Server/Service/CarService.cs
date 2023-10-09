﻿using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class CarService : BaseService, ICarService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public CarService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");        }        public Task<T> CreateAsync<T>(CarCreateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/CarAPI/CreateCar"            });        }        public Task<T> DeleteAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/CarAPI/DeleteCar/" + id            });        }        public Task<T> GetAllAsync<T>()        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/CarAPI/GetCars"            });        }        //public Task<T> GetCarData<T>(int pageNum, string token)        //{        //    string apiUrl = $"{carUrl}/api/v1/CarAPI/GetCarData?pageNum={pageNum}";        //    return SendAsync<T>(new APIRequest()        //    {        //        ApiType = SD.ApiType.GET,        //        Url = apiUrl,        //        Token = token        //    });        //}        public Task<T> GetAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/CarAPI/GetCar/" + id            });        }        public Task<T> UpdateAsync<T>(CarUpdateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/CarAPI/UpdateCar/" + dto.Id            });        }
        public Task<T> CarSearchByLazyLoading<T>(int pageNum, string searchText)
        {
            string apiUrl = $"{carUrl}/api/v1/CarAPI/CarSearchByLazyLoading?pageNum={pageNum}&searchText={searchText}";
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = apiUrl
            });
        }
		public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage)
		{
			//string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
			string apiUrl = $"{carUrl}/api/v1/CarAPI/GetDataIndex?term={term}&orderBy={orderBy}&currentPage={currentPage}";

			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = apiUrl
			});

		}
	}}
