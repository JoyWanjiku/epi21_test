using epi21_test.Controllers;
using epi21_test.Models.Movies;
using System.Net.Http;
using System.Threading.Tasks;

namespace epi21_test.Models.Interfaces
{
    public class MovieService : IMovieService
    {
        public async Task<MovieSearch> Search(string s)
        {
            var url = $"http://www.omdbapi.com/?apikey=d0c2e44a&s={s}";

            MovieSearch searchResult = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    searchResult = await response.Content.ReadAsAsync<MovieSearch>();
                }
            }

            return searchResult;
        }

        public async Task<Movie> Get(string id)
        {
            var url = $"https://www.omdbapi.com/?i={id}&apikey=d0c2e44a";
            Movie movie = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    movie = await response.Content.ReadAsAsync<Movie>();
                }
            }

            return movie;
        }
    }
}