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
          GUID = "56DA62B2-4C5E-49AB-8977-A4A038A88595",
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