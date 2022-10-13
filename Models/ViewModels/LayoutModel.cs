using epi21_test.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Models.ViewModels
{
    public class LayoutModel
    {
     public IEnumerable<PageData> Menu { get; set; }

    public NackademinStartPage StartPage { get; set; }
}
}