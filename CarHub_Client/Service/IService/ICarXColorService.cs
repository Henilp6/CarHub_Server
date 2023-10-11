﻿
	public interface ICarXColorService
	{

		Task<T> GetAllAsync<T>();
		Task<T> GetAsync<T>(int id);
		Task<T> CreateAsync<T>(CarXColorCreateVM dto);
		Task<T> UpdateAsync<T>(CarXColorUpdateVM dto);
		Task<T> DeleteAsync<T>(int id);
		

	}