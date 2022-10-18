using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace epi21_test.Extensions
{
    public static class StringExtensions
    {
            public static bool IsNotNullOrWhiteSpace(this string value)
            {
                return !string.IsNullOrWhiteSpace(value);
            }
        
    }
}
