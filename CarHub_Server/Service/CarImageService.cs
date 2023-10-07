﻿using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Server.Service.IService;

namespace CarHub_Server.Service
        public Task<T> SetAsync<T>(int imageId, int carId, string token)
        {
            string apiUrl = $"{carUrl}/api/v1/CarImageAPI/{imageId}/{carId}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                // Data = dto,
                Url = apiUrl,
                Token = token
            });
        }