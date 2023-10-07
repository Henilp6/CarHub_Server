using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarHub_Models
{
    public class StateUpdateDTO
    {
[Required]
        public int Id { get; set; }

        [Required]
        [DisplayName("State Name")]
        public string StateName { get; set; }

        public int CountryId { get; set; }


        public bool IsActive { get; set; }


    }
}
