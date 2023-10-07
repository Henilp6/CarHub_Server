using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarHub_Models.ViewModels
{
	public class CarXFeatureUpdateVM
	{
		public CarXFeatureUpdateVM()
		{
			CarXFeature = new CarXFeatureUpdateDTO();
		}
		public CarXFeatureUpdateDTO CarXFeature { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> CarList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> FeatureTypeList { get; set; }
		[ValidateNever]
		public List<FeatureVM> Featurelist { get; set; }
	}
}
