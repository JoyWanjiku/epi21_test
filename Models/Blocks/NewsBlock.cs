using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

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
            Order = 10
        )]
        public virtual PageReference NewsContainer { get; set; }

    }
}