using epi21_test.Content;
using EPiServer.Shell;


namespace epi21_test.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ArticleTreeIconDescriptor : UIDescriptor<IUseArticleTreeIcon>
    {
        public ArticleTreeIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ObjectIcons.Category;
        }
    }
    public interface IUseArticleTreeIcon
    {
    }
}