using epi21_test.Models.Pages;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.ViewModels
{
    public class ResultViewModel : PageViewModel<FindPage>
    {
        public UnifiedSearchResults Results { get; set; }
        public ResultViewModel(FindPage currentPage) : base(currentPage)
        {

        }
    }
}