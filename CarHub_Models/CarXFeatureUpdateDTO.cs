﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarHub_Models
{
    public class CarXFeatureUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CarId { get; set; }

        [Required]
        public int FeatureTypeId { get; set; }
        
        [Required]
        public int FeatureId { get; set; }
       
    }
}
