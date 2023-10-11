

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarHub_Models.ViewModels
{
	public class CarImagesCreateVM
	{
		public CarImagesCreateVM()
		{
			CarImage = new CarImageCreateDTO();
			Car = new CarCreateDTO();
		}
        [ValidateNever]
        public CarImageCreateDTO CarImage { get; set; }
	
		public CarCreateDTO Car { get; set; }
		//      [ValidateNever]
		//public IEnumerable<SelectListItem> CarList { get; set; }
		[ValidateNever]
		public List<CarImageCreateDTO> CarImagelist { get; set; } = new List<CarImageCreateDTO>();
	}
}
