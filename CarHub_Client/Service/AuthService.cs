﻿using CarHub_Common;
using CarHub_Models;
using CarHub_Models.API;
using CarHub_Models.ViewModels;
using CarHub_Client.Service.IService;

namespace CarHub_Client.Service
	public class AuthService : BaseService, IAuthService
		private readonly IHttpClientFactory _clientFactory;
		private string carUrl;

		public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
		{
			_clientFactory = clientFactory;
            carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}

		public Task<T> LoginAsync<T>(LoginRequestDTO obj)