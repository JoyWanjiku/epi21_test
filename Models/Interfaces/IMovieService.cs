using epi21_test.Models.Movies;
using System.Threading.Tasks;

namespace epi21_test.Controllers
{
    public interface IMovieService
    {
        Task<MovieSearch> Search(string s);

        Task<Movie> Get(string id);
    }
}