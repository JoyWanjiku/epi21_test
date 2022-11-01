using epi21_test.Models.Container;
using epi21_test.Models.Interfaces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace epi21_test.Models.Pages
{
    [ContentType(
          GUID = "9F8EAAE2-E6FC-4850-8337-0E5DE1E189F5",
          DisplayName = "A start page",
          Description = "This is a start page",
        GroupName = Global.GroupNames.Common
    )]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ArticlePage), typeof(NewsContainer),
            typeof(FindPage), typeof(MovieSearchPage) }
    )]
    public class NackademinStartPage : SitePageData, ISearchable
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
            )]
        [CultureSpecific]
        public virtual ContentArea ContentArea { get; set; } //adding a content area on epi where we can drag and drop pages or blocks

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
            )]
        [CultureSpecific]
        public virtual XhtmlString Header { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        [UIHint("BackgroundColor")]
        public virtual string BackgroundColor { get; set; }


    }
}