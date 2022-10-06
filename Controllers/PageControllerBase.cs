using epi21_test.Business;
using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace epi21_test.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T>, IModifyLayout
        where T : SitePageData
    {

        protected EPiServer.ServiceLocation.Injected<UISignInManager> UISignInManager;

        public ActionResult Logout()
        {
            UISignInManager.Service.SignOut();
            return RedirectToAction("Index");
        }
        public virtual void ModifyLayout(LayoutModel layoutModel)
        {
            var page = PageContext.Page as SitePageData;
        }
    }
}