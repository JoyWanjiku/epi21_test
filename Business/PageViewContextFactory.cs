using epi21_test.Models.Pages;
using epi21_test.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using log4net;
using System.Linq;
using System.Reflection;
using System.Web.Routing;

namespace epi21_test.Business.Initializers
{
    public class PageViewContextFactory
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IContentLoader _contentLoader;

        public PageViewContextFactory(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            var startPageContentLink = SiteDefinition.Current.StartPage;

            if (currentContentLink.CompareToIgnoreWorkID(startPageContentLink))
            {
                startPageContentLink = currentContentLink;
            }

            var startPage = _contentLoader.Get<NackademinStartPage>(startPageContentLink);

            return new LayoutModel
            {
                Menu = _contentLoader.GetChildren<PageData>(startPage.ContentLink).ToList().Where(x => x.VisibleInMenu),
                StartPage = startPage,
                //SetttingsPage = GetSettingsPage(),
                //StartPages = GetStartPages()
            };
        }
    }
}