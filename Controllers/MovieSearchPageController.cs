using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace epi21_test.Controllers
{
    public class MovieSearchPageController : PageControllerBase<MovieSearchPage>
    {
        private IMovieService _movieService;

        public MovieSearchPageController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public async Task<ActionResult> Index(MovieSearchPage currentPage, string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return View(new MovieSearchViewModel(currentPage));
            }
            else
            {
                var searchResult = await _movieService.Search(query);

                return View(new MovieSearchViewModel(currentPage) { Search = searchResult });
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetMovie(MovieSearchPage currentPage, string id)
        {
            var movie = await _movieService.Get(id);

            var model = new MovieSearchViewModel(currentPage)
            {
                Movie = movie
            };

            return View(model);
        }
    }
}