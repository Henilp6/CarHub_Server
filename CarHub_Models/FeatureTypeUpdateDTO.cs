using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarHub_Models
{
    public class FeatureTypeUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "FeatureType Name")]
        public string FeatureTypeName { get; set; }
    }
}
