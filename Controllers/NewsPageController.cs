using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace epi21_test.Controllers
{
    public class NewsPageController : PageController<NewsPage>
    {
        public ActionResult Index(NewsPage currentPage)
        {
            var model = new NewsPageViewModel(currentPage);

            return View(model);
        }
    }
}