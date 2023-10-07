﻿using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service
			carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}
        public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage, string token)
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData?term={term}&orderBy={orderBy}&currentPage={currentPage}";
        
