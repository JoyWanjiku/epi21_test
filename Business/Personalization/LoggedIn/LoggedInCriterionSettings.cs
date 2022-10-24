using EPiServer.Personalization.VisitorGroups;


namespace epi21_test.Business.Personalization.LoggedIn
{
 
        public class LoggedInCriterionSettings : CriterionModelBase
        {
            public override ICriterionModel Copy()
            {
                return ShallowCopy();
            }
        }
    
}