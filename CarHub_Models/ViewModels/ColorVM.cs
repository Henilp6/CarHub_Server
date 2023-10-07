using CarHub_Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarHub_Models.ViewModels
{
    public class ColorVM
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Color Name")]
        public string ColorName { get; set; }
       
        public bool IsChecked { get; set; }

    }
}
