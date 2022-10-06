using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public T CurrentPage { get; private set; }
        public LayoutModel Layout { get; set; }
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

    }
}