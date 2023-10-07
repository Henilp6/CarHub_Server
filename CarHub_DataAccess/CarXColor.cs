using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarHub_DataAccess
{
    public class CarXColor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }
        [ValidateNever]
        public Car Car { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        [ValidateNever]
        public Color Color { get; set; }
    }
}


//-Id
//- CarId
//- ColorId