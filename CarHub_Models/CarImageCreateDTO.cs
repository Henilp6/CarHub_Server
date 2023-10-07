using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarHub_Models
{
    public class CarImageCreateDTO
    {
        public int Id { get; set; }
    

        public string ImageUrl { get; set; }

       
        public int CarId { get; set; }
      
    }
}
