using CarHub_Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CarHub_Models.ViewModels
{
    public class FeatureVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Feature Name")]
        public string Name { get; set; }
        public int FeatureTypeId { get; set; }
        [ValidateNever]
        public FeatureTypeDTO FeatureType { get; set; }
        public string FeatureTypeName { get; set; }

        public bool IsChecked { get; set; }


    }
}
