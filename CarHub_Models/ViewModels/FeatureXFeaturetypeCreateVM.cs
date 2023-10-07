﻿using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarHub_Models.ViewModels
{
	public class FeatureXFeaturetypeCreateVM
    {
		public FeatureXFeaturetypeCreateVM()
		{
            FeatureXFeaturetype = new FeatureXFeaturetypeCreateDTO();
			
		}
		public FeatureXFeaturetypeCreateDTO FeatureXFeaturetype { get; set; }
		
		public List<FeatureXFeaturetypeCreateDTO> FeatureXFeaturetypelist { get; set; }
		
		[ValidateNever]
		public IEnumerable<SelectListItem> FeatureTypeList { get; set; }
		[ValidateNever]
		public List<FeatureVM> Featurelist { get; set; }
	}
}
