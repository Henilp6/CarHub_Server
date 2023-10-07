﻿using CarHub_Models;

namespace CarHub_Server.Service.IService
{
    public interface IApplicationUserRoleService
    {

        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(string Id, string token);


    }
}
