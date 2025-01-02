using AleksaPortfolio.Models.Interfaces;
using AleksaPortfolio.Models.Model;
using AleksaPortfolio.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AleksaPortfolio.Models.Factory
{
    public class IntroTextModuleFactory : IIntroTextModuleFactory
    {
        private readonly IPublishedValueFallback _publishedValueFallback;

        public IntroTextModuleFactory(IPublishedValueFallback publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;
        }

        public IntroTextModuleViewModel Create(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new IntroTextModuleViewModel
            {
                LargeTitleText = GetPropertyValue<string>(element, "largeTitleText"),
                SmallTitleText = GetPropertyValue<string>(element, "smallTitleText"),
                Image = GetPropertyValue<MediaWithCrops>(element, "image"),
                TagText = GetPropertyValue<string>(element, "tagText"),
                Links = GetPropertyValue<BlockListModel>(element, "links")
            };
        }

        private T? GetPropertyValue<T>(IPublishedElement element, string alias)
        {
            var property = element.GetProperty(alias);
            return property != null ? (T?)property.GetValue() : default;
        }
    }
}
