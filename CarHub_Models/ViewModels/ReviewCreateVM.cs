﻿using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarHub_Models.ViewModels
{
	public class ReviewCreateVM
    {
		public ReviewCreateVM()
		{
            Review = new ReviewCreateDTO();
			Car = new CarDTO();
		}
        public ReviewCreateDTO Review { get; set; }
		public CarDTO Car { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> CarList { get; set; }
		
	}
}
