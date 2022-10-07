using epi21_test.Models.Pages;
using EPiServer.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ForceAllPropertiesViewUiDescriptor : UIDescriptor<NackademinStartPage>
    {
        public ForceAllPropertiesViewUiDescriptor()
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}