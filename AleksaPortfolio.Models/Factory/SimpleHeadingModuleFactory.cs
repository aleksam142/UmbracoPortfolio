using AleksaPortfolio.Models.Interfaces;
using AleksaPortfolio.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AleksaPortfolio.Models.Factory
{
    public class SimpleHeadingModuleFactory : ISimpleHeadingModuleFactory
    {
        public SimpleHeadingModuleViewModel Create(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new SimpleHeadingModuleViewModel
            {
                Heading = GetPropertyValue<string>(element, "heading")
            };
        }

        private T? GetPropertyValue<T>(IPublishedElement element, string alias)
        {
            var property = element.GetProperty(alias);
            return property != null ? (T?)property.GetValue() : default;
        }
    }
}
