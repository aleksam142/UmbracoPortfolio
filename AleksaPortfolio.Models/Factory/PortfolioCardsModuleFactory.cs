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
    public class PortfolioCardsModuleFactory : IPortfolioCardsModuleFactory
    {
        public PortfolioCardsModuleViewModel Create(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new PortfolioCardsModuleViewModel
            {
                Title = GetPropertyValue<string>(element, "title"),
                TitleColor = ((bool)(GetPropertyValue<string>(element, "titleColor")?.Equals("Blue")) ? "primary" : "secondary"),
                PortfolioLinks = GetPropertyValue<IEnumerable<Link>>(element, "downloadLinks"),
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
