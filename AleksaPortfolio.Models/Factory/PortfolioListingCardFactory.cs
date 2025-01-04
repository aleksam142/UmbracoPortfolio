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
    public class PortfolioListingCardFactory : IPortfolioListingCardFactory
    {
        public PortfolioListingCardViewModel Create(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new PortfolioListingCardViewModel
            {
                FromDate = GetPropertyValue<DateTime>(element, "fromDate").Year.ToString(),
                ToDate = (GetPropertyValue<DateTime>(element, "toDate") != DateTime.MinValue) ? GetPropertyValue<DateTime>(element, "toDate").Year.ToString() : "Present",
                Company = GetPropertyValue<string>(element, "company"),
                DateColor = (bool)(GetPropertyValue<string>(element, "dateColor")?.Equals("Blue")) ? "primary" : "secondary",
                Description = GetPropertyValue<string>(element, "description"),
                Location = GetPropertyValue<string>(element, "location"),
                Position = GetPropertyValue<string>(element, "position")
            };
        }

        private T? GetPropertyValue<T>(IPublishedElement element, string alias)
        {
            var property = element.GetProperty(alias);
            return property != null ? (T?)property.GetValue() : default;
        }
    }
}
