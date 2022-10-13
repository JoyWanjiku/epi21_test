using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace epi21_test.Controllers
{
    public class FindPageController : PageControllerBase<FindPage>
    {
     public ActionResult Index(FindPage currentPage, string query)
        {
            var model = new ResultViewModel(currentPage);
            var hitSpec = new HitSpecification
            {
                ExcerptLength = 255
            };
            if (string.IsNullOrEmpty(query))
            {
                return View(model);
            }
            else
            {
                var result = SearchClient.Instance.UnifiedSearchFor(query, EPiServer.Find.Language.English).UsingSynonyms().ApplyBestBets();
                model.Results = result.Take(100).GetResult(hitSpec);

                return View(model);
            }
        }   
    }
}