using epi21_test.Content;
using EPiServer.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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