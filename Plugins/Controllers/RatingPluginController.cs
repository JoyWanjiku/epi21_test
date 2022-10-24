using epi21_test.Plugins.Models;
using EPiServer.PlugIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace epi21_test.Plugins.Controllers
{
    [GuiPlugIn(
        Area = PlugInArea.AdminMenu,
        Url = "/RatingPlugin",
        DisplayName = "Ratings"
    )]
    [Authorize(
        Roles = "Administrators, WebAdmins, CmsAdmins"
    )]
    public class RatingPluginController : Controller
    {
        public ActionResult Index()
        {
            var model = new RatingViewModel();
            model.Ratings = model.CreateRatings();

            return View("~/Plugins/Views/RatingPlugin/Index.cshtml", model);
        }
    }
}