using epi21_test.Models.Blocks;
using epi21_test.Models.Container;
using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace epi21_test.Controllers.Blocks
{
    public class NewsBlockController : BlockController<NewsBlock>
    {
        private readonly IContentLoader _contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

        public override ActionResult Index(NewsBlock currentBlock)
        {
            NewsContainer newsContainer = null;
            if (!ContentReference.IsNullOrEmpty(currentBlock.NewsContainer))
            {
                newsContainer = _contentLoader.Get<NewsContainer>(currentBlock.NewsContainer);
            }
            var model = new NewsViewModel() 
            {
                News = _contentLoader.GetChildren<NewsPage>(newsContainer.ContentLink)
            };
     
            return PartialView(model);
        }
    }
}