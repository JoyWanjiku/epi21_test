using epi21_test.Business.UIDescriptors;
using epi21_test.Models.Pages;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace epi21_test.Models.Container
{
    [ContentType(
       GUID = "F3F04879-EC58-4813-85B8-407A8FAEAE27", //blocks are dragged and dropped, checkout alloy
       GroupName = Global.GroupNames.Specialized,
       DisplayName = "Container: News",
       Description = "This is a new container"
 )]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(NewsPage)}
        )]
    public class NewsContainer : SitePageData, IUseArticleTreeIcon

    {

    }
}