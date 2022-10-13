using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.Pages
{
    [ContentType(
        GUID = "18F39152-BEA5-4658-8299-9AA2B0126C16",
        DisplayName = "Page: Article",
        Description = "This is an article page"
    )]
    public class ArticlePage : SitePageData
    {
    }
}