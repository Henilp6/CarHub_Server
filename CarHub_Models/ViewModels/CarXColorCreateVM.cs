using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarHub_Models.ViewModels
{
    public class CarXColorCreateVM
    {
        public CarXColorCreateVM()
        {
            CarXColor = new CarXColorCreateDTO();
            Car = new CarCreateDTO();
        }
        public CarXColorCreateDTO CarXColor { get; set; }
        public List<CarXColorCreateDTO> CarXColorlist { get; set; } = new List<CarXColorCreateDTO>();
        public CarCreateDTO Car { get; set; }
        //      [ValidateNever]
        //public IEnumerable<SelectListItem> CarList { get; set; }
        [ValidateNever]
        public List<ColorVM> Colorlist { get; set; } = new List<ColorVM>();
    }
}
