using epi21_test.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.ViewModels
{
    public class StartPageViewModel : PageViewModel<NackademinStartPage>
    {
        public StartPageViewModel(NackademinStartPage currentPage) : base(currentPage)
        {

        }
    }
}