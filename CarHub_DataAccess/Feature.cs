using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace CarHub_DataAccess
{

    public class Feature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Feature Name")]
        public string Name { get; set; }
        public int FeatureTypeId { get; set; }
        [ValidateNever]
        public FeatureType FeatureType { get; set; }

    }
}
