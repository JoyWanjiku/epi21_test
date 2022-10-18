using epi21_test.Models.Pages;

namespace epi21_test.Models.ViewModels
{
    public class NewsPageViewModel : PageViewModel<NewsPage>
    {
        public NewsPageViewModel(NewsPage currentPage) : base(currentPage)
        {
        }
    }
}