using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace epi21_test.Models.Blocks
{
    [ContentType(
        GUID = "E4F037D6-0BCB-4768-BB58-9099E6C8CEFF",
        DisplayName = "Block: List news",
        Description = "This is a list news block"
        )]
    public class NewsBlock : SiteBlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1
        )]
        public virtual PageReference NewsContainer { get; set; }

    }
}