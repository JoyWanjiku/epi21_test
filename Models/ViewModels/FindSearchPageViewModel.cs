using epi21_test.Models.Pages;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.ViewModels
{
    public class FindSearchPageViewModel : PageViewModel<FindPage>
    {
        public FindSearchPageViewModel(FindPage currentPage, string searchQuery)
          : base(currentPage)
        {
            SearchQuery = searchQuery;
        }
        public string SearchQuery { get; private set; }
        public UnifiedSearchResults Results { get; set; }
    }
}