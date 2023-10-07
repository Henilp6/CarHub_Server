using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarHub_Models
{
    public class ColorUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Color Name")]
        public string ColorName { get; set; }
    }
}
