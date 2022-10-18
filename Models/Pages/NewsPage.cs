using epi21_test.Business.UIDescriptors;
using epi21_test.Models.Interfaces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace epi21_test.Models.Pages
{
    [ContentType (
        GUID = "AB3B291B-2246-411B-949D-0405F93B3C89",
        DisplayName = "Page: News",
        Description = "this is a news page"
        )]
    public class NewsPage : SitePageData, ISearchable, IUseArticleTreeIcon
    {
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 40
           )]
        [CultureSpecific]
        public virtual XhtmlString Text { get; set; }
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
        
    }
}