﻿using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service
			carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}
        public Task<T> GetCountryData<T>(int pageNum, string token)
            string apiUrl = $"{carUrl}/api/v1/CountryAPI/GetCountryData?pageNum={pageNum}";

        }
        public Task<T> CountryByPagination<T>(string term, string orderBy, int currentPage)
        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/CountryAPI/CountryByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = apiUrl
               
            });

        }