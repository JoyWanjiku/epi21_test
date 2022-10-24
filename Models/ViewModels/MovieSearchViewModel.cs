using epi21_test.Models.Movies;
using epi21_test.Models.Pages;

namespace epi21_test.Models.ViewModels
{
    public class MovieSearchViewModel : PageViewModel<MovieSearchPage>
    {
        public MovieSearch Search { get; set; }

        public Movie Movie { get; set; }

        public MovieSearchViewModel(MovieSearchPage currentPage) : base(currentPage)
        {
        }
    }
}