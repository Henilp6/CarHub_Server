using CarHub_Models;

namespace CarHub_Models.ViewModels
{
    public class FeatureIndexVM
	{

        // public IQueryable<State> states { get; set; }

        public IEnumerable<FeatureDTO> Features { get; set; } = new List<FeatureDTO>();
        public string NameSortOrder { get; set; }
        // public string EmailSortOrder { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Term { get; set; }
        public string OrderBy { get; set; }

    }
}
