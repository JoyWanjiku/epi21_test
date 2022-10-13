using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace epi21_test.Models.Pages
{
    [ContentType (
        GUID = "AB3B291B-2246-411B-949D-0405F93B3C89",
        DisplayName = "Page: News",
        Description = "this is a news page"
        )]
    public class NewsPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
            )]
        [CultureSpecific]
        public virtual XhtmlString Text { get; set; }
    }
}