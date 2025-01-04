using AleksaPortfolio.Models.Interfaces;
using AleksaPortfolio.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AleksaPortfolio.Models.Factory
{
    public class ProjectsModuleFactory : IProjectsModuleFactory
    {
        public ProjectsModuleViewModel Create(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new ProjectsModuleViewModel
            {
                Title = GetPropertyValue<string>(element, "title"),
                Cards = GetPropertyValue<BlockListModel>(element, "cards")
            };
        }

        private T? GetPropertyValue<T>(IPublishedElement element, string alias)
        {
            var property = element.GetProperty(alias);
            return property != null ? (T?)property.GetValue() : default;
        }
    }
}
