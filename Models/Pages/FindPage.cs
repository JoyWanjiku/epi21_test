using epi21_test.Business.UIDescriptors;
using EPiServer.DataAnnotations;

namespace epi21_test.Models.Pages
{
    [ContentType(
        GUID = "B3710E58-AC2A-4E67-BBBF-4019F3F5C647",
        DisplayName = "Page : Find",
        Description = "This is a find page"
        )]
    public class FindPage : SitePageData, IUseArticleTreeIcon
    {
    }
}