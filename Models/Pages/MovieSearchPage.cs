using epi21_test.Business.UIDescriptors;
using EPiServer.DataAnnotations;

namespace epi21_test.Models.Pages
{
    [ContentType(
           GUID= "673C61DD-64E5-4E93-9956-13F2F184A42F",
           DisplayName = "Page: Movie Search",
           Description = "This is a movie search page"
           )]
    public class MovieSearchPage : SitePageData , IUseArticleTreeIcon
    { 
    }
}