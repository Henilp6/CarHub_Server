﻿using CarHub_Models;

namespace CarHub_Models.ViewModels
{
    public class MileageIndexVM
    {

        // public IQueryable<State> states { get; set; }

        public IEnumerable<MileageDTO> Mileages { get; set; }
        public string NameSortOrder { get; set; }
        // public string EmailSortOrder { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Term { get; set; }
        public string OrderBy { get; set; }

    }
}
