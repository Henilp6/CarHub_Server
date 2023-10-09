using CarHub_Models;

namespace CarHub_Models.ViewModels
{
    public class CarSpecificationIndexVM
    {

        // public IQueryable<State> states { get; set; }

        public IEnumerable<CarSpecificationDTO> CarSpecifications { get; set; } = new List<CarSpecificationDTO>();
        public string NameSortOrder { get; set; }
        // public string EmailSortOrder { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Term { get; set; }
        public string OrderBy { get; set; }

    }
}
