﻿using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service{    public class VariantService : BaseService, IVariantService    {        private readonly IHttpClientFactory _clientFactory;        private string carUrl;        public VariantService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");        }        public Task<T> CreateAsync<T>(VariantCreateVM dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = carUrl + "/api/v1/VariantAPI/CreateVariant/",                           });        }        public Task<T> DeleteAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = carUrl + "/api/v1/VariantAPI/DeleteVariant/" + id,                        });        }        public Task<T> GetAllAsync<T>()        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/VariantAPI/GetVariants",                           });        }        public Task<T> GetAsync<T>(int id)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = carUrl + "/api/v1/VariantAPI/GetVariant/" + id,                            });        }        public Task<T> UpdateAsync<T>(VariantUpdateDTO dto)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = carUrl + "/api/v1/VariantAPI/UpdateVariant/" + dto.Id,                          });        }
		public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage)
		{
			//string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
			string apiUrl = $"{carUrl}/api/v1/VariantAPI/VariantByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";

			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = apiUrl,
			
			});

		}
	}}
