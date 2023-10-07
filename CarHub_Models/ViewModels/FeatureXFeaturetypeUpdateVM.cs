using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarHub_Models.ViewModels
{
	public class FeatureXFeaturetypeUpdateVM
    {
		public FeatureXFeaturetypeUpdateVM()
		{
            FeatureXFeaturetype = new FeatureXFeaturetypeUpdateDTO();
		}
		public FeatureXFeaturetypeUpdateDTO FeatureXFeaturetype { get; set; }
		
		[ValidateNever]
		public IEnumerable<SelectListItem> FeatureTypeList { get; set; }
		[ValidateNever]
		public List<FeatureVM> Featurelist { get; set; }
	}
}
