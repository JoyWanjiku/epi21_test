using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using System.Web.Mvc;

namespace epi21_test.Controllers
{
    public class NackademinStartPageController : PageControllerBase<NackademinStartPage>
    {
        public ActionResult Index(NackademinStartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}