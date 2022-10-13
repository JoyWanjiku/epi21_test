using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace epi21_test.Controllers
{
    [TemplateDescriptor(Default = true)]
    public class FindSearchPageController : PageController<FindPage>
    {
        public ActionResult Index(FindPage currentPage, string q)
        {
            var model = new FindSearchPageViewModel(currentPage, q);
            if (String.IsNullOrEmpty(q))
            {
                return View(model);
            }
            var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(q);
            model.Results = unifiedSearch.GetResult();
            return View(model);
        }
    }
}
