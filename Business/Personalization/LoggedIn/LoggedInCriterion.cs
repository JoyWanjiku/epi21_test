using epi21_test.Business.Personalization.LoggedIn;
using EPiServer.Personalization.VisitorGroups;
using System.Security.Principal;
using System.Web;

namespace epi21_test.Business.Persoalization
{
    [VisitorGroupCriterion(
        Category = "Technical",
        DisplayName = "Logged in",
        Description = "Checks if a logged in cookie exists"
    )]
    public class LoggedInCriterion : CriterionBase<LoggedInCriterionSettings>
    {
        public override bool IsMatch(IPrincipal principal, HttpContextBase httpContext)
        {
            return httpContext.Request.Cookies[".EpiServerLogin"] != null;
        }
    }
    
}