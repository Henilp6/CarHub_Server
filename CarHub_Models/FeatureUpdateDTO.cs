using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarHub_Models
{
    public class FeatureUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Feature Name")]
        public string Name { get; set; }
        public int FeatureTypeId { get; set; }
    }
}
