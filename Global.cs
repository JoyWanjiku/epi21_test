using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace epi21_test
{
    public class Global
    {
        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Specialized", Order = 10)]
            public const string Specialized = "Specialized";
        }
    }
}