﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarHub_Models
{
    public class FeatureXFeaturetypeDTO
    {
        public int Id { get; set; }


        [Required]
        
        public int FeatureTypeId { get; set; }
        [ValidateNever]
        public FeatureTypeDTO FeatureType { get; set; }
        [Required]
        
        public int FeatureId { get; set; }
        [ValidateNever]
        public FeatureDTO Feature { get; set; }
    }
}
