using EPiServer.Core;
using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.ServiceLocation;
using epi21_test.Extensions;
using epi21_test.Models.Interfaces;
using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace epi21_test.Controllers
{
    public class FindPageController : PageControllerBase<FindPage>
    {
        public ActionResult Index(FindPage currentPage, string query)
        {
            var model = new ResultViewModel(currentPage);

            if (query.IsNotNullOrWhiteSpace())
            {
                var searchClient = ServiceLocator.Current.GetInstance<IClient>();
                var result = searchClient.Search<PageData>().For(query).GetPagesResult().Where(x => x is ISearchable);

                model = new ResultViewModel(currentPage)
                {
                    Result = result
                };
            }

            return View(model);
        }
    }
}