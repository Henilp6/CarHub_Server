﻿using AutoMapper;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;
using CarHub_Models;
using CarHub_Models.ViewModels;
    [Route("api/v{version:apiVersion}/[controller]/[Action]")]
    [ApiController]
        //[ProducesResponseType(200, Type =typeof(VillaDTO))]
        //        [ResponseCache(Location =ResponseCacheLocation.None,NoStore =true)]
        public async Task<ActionResult<APIResponse>> GetCarXColor(int id)
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
                // CarXColor carxcolor = _mapper.Map<CarXColor>(createDTO.CarXColor);
                Car car = _mapper.Map<Car>(createDTO.Car);
                List<CarXColor> carXColorlist = await _unitOfWork.CarXColor.GetAllAsync(u => u.CarId == car.Id, includeProperties: "Car,Color");

                //  await _unitOfWork.CarXColor.RemoveRangeAsync(carXColorlist, false);
                //foreach (var carlist in carXColorlist)
                //{
                //	CarXColor carxColor = new();

                //	carxColor.Id = carlist.Id;
                //	carxColor.CarId = carlist.CarId;
                //	carxColor.ColorId = carlist.ColorId;
                //	await _unitOfWork.CarXColor.RemoveAsync(carxColor);
                //}


                foreach (var colorlist in colorVMList)
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<APIResponse>> DeleteCarXColor(int id)

        // [Authorize(Roles = "admin")]
        [HttpPut(Name = "UpdateCarXColor")]