using EPiServer.Cms.Shell;
using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;

namespace epi21_test.Business.Initializers
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class CategoryInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            CreateCategories();
        }
        private void CreateCategories()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var root = categoryRepository.GetRoot();

            if (categoryRepository.Get("[Fotbollslag]") == null)
            {
                var systemCategory = new Category(root, "[Fotbollslag]")
                {
                    Description = "[Fotbollslag]",
                    Selectable = false
                };
                categoryRepository.Save(systemCategory);

                var system = categoryRepository.Get("[Fotbollslag]");

                var team = new Category(system, "Djurgården")
                {
                    Description = "[Fotbollslag]",
                    Selectable = false
                };
                categoryRepository.Save(team);
            }
            if (categoryRepository.Get("Djurgården") != null)
            {
                var dif = categoryRepository.Get("Djurgården");
                var categories = new List<string>
                {
                    "Damer",
                    "Herrar",
                    "Juniorer"
                };
                foreach (var category in categories)
                {
                    if (categoryRepository.Get(category) == null)
                    {
                        var kategori = new Category(dif, category)
                        {
                            Description = category
                        };
                        categoryRepository.Save(kategori);
                    }
                }
            }

        }
        public void Uninitialize(InitializationEngine context)
        {
            throw new NotImplementedException();
        }
    }
}