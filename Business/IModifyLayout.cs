using epi21_test.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Business
{
    public interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}