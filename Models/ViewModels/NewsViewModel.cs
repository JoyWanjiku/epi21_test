using epi21_test.Models.Pages;
using System.Collections.Generic;

namespace epi21_test.Models.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<NewsPage> News { get; set; }
    }
}