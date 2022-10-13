using epi21_test.Business.UIDescriptors;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.Pages
{
    [ContentType(
         GUID = "DC1D1D70-EF17-4362-9C3D-748BE78946F0",
         DisplayName = "This is an article page",
         Description = "Article page",
         Order = 10,
         GroupName = "Content")]
    public class ArticlePageType : IUseArticleTreeIcon
    {
        //
        /* ... code goes here */
        //
    }
}