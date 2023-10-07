using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarHub_Models
{
    public class CarXColorCreateDTO
    {
        public int Id { get; set; }
        
        public int CarId { get; set; }
        
     
        public int ColorId { get; set; }
     
    }
}
