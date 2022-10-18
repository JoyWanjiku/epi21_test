using epi21_test.Business.UIDescriptors;
using epi21_test.Models.Interfaces;
using EPiServer.DataAnnotations;


namespace epi21_test.Models.Pages
{
    [ContentType(
        GUID = "18F39152-BEA5-4658-8299-9AA2B0126C16",
        DisplayName = "Page: Article",
        Description = "This is an article page"
    )]
    public class ArticlePage : SitePageData, ISearchable, IUseArticleTreeIcon
    {
    }
}