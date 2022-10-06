using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.ViewModels
{
   
        public interface IPageViewModel<out T> where T : PageData
        {
            T CurrentPage { get; }
            LayoutModel Layout { get; set; }

        }
    
}