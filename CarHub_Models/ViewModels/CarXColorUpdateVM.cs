using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarHub_Models.ViewModels
{
	public class CarXColorUpdateVM
	{
		public CarXColorUpdateVM()
		{
			CarXColor = new CarXColorUpdateDTO();
		}
		public CarXColorUpdateDTO CarXColor { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> CarList { get; set; }
        
        [ValidateNever]
		public List<ColorVM> Colorlist { get; set; }
	}
}
