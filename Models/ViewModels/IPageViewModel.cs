using epi21_test.Models.Pages;
using EPiServer.Core;


namespace epi21_test.Models.ViewModels
{
   
        public interface IPageViewModel<out T> where T : SitePageData
        {
            T CurrentPage { get; }
            LayoutModel Layout { get; set; }
            IContent Section { get; set; }

        }
    
}