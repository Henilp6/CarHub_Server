﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarHub_Models
{
    public class FeatureXFeaturetypeCreateDTO
    {

        public int Id { get; set; }
        [Required]
        public int FeatureTypeId { get; set; }
        
        [Required]
        
        public int FeatureId { get; set; }
        
    }
}
