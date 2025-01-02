using AleksaPortfolio.Models.Interfaces;
using AleksaPortfolio.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AleksaPortfolio.Models.Factory
{
    public class SocialModuleFactory : ISocialModuleFactory
    {
        public SocialModuleViewModel Create(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new SocialModuleViewModel
            {
                MainTitle = GetPropertyValue<string>(element, "mainTitle"),
                SmallTitle = GetPropertyValue<string>(element, "smallTitle"),
                ModuleText = GetPropertyValue<string>(element, "moduleText"),
                SocialLinks = GetPropertyValue<BlockListModel>(element, "socialLinks")
            };
        }

        private T? GetPropertyValue<T>(IPublishedElement element, string alias)
        {
            var property = element.GetProperty(alias);
            return property != null ? (T?)property.GetValue() : default;
        }
    }
}
