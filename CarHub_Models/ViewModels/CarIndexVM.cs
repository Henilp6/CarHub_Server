using CarHub_Models;

namespace CarHub_Models.ViewModels
{
    public class CarIndexVM
	{

        // public IQueryable<State> states { get; set; }

        public IEnumerable<CarDTO> Cars { get; set; }
        public string NameSortOrder { get; set; }
        // public string EmailSortOrder { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Term { get; set; }
        public string OrderBy { get; set; }

    }
}
