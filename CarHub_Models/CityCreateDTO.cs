using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarHub_Models
{
    public class CityCreateDTO
    {

        public int Id { get; set; }

        [Required]
        [DisplayName("City Name")]
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public bool IsActive { get; set; }


    }
}
