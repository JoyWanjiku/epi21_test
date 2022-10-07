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
    [ContentType(
          GUID = "9F8EAAE2-E6FC-4850-8337-0E5DE1E189F5",
          DisplayName = "A start page"
    )]
    public class NackademinStartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        [CultureSpecific]
        public virtual XhtmlString Header { get; set; }
    }
}