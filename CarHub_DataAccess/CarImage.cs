using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarHub_DataAccess
{
    public class CarImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        [ValidateNever]
        public Car Car { get; set; }
    }
}
