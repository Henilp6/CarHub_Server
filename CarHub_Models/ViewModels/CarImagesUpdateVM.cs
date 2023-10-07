
using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarHub_Models.ViewModels
{
	public class CarImagesUpdateVM
	{
		public CarImagesUpdateVM()
		{
            CarImage = new CarImageUpdateDTO();
            Car = new CarCreateDTO();
        }
        public CarImageUpdateDTO CarImage { get; set; }

        public CarCreateDTO Car { get; set; }
     
        [ValidateNever]
        public List<CarImageCreateDTO> CarImagelist { get; set; }
    }
}
