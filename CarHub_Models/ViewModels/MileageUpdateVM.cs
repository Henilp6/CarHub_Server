using CarHub_Models;

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace CarHub_Models.ViewModels
{
    public class MileageUpdateVM
    {
        public MileageUpdateVM()
        {
            Mileage = new MileageUpdateDTO();
			Car = new CarCreateDTO();
		}
        public MileageUpdateDTO Mileage { get; set; }
		[ValidateNever]
		public CarCreateDTO Car { get; set; }
		[ValidateNever]
        public IEnumerable<SelectListItem> CarList { get; set; }

    }
}
