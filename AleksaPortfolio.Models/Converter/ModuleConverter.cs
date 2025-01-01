using AleksaPortfolio.Models.Interfaces;
using AleksaPortfolio.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace AleksaPortfolio.Models.Converter
{
    public class ModuleConverter
    {
        private readonly IPublishedValueFallback _publishedValueFallback;

        private readonly Dictionary<string, Func<IPublishedElement, IModuleViewModel>> _moduleMappings;

        public ModuleConverter(IPublishedValueFallback publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;

            _moduleMappings = new Dictionary<string, Func<IPublishedElement, IModuleViewModel>>
        {
            {
                "formspreeContactFormModule",
                element => new FormspreeFormModuleViewModel
                {
                    FormTitle = GetPropertyValue<string>(element, "formTitle"),
                    FormDescription = GetPropertyValue<string>(element, "formDescription"),
                    EmbedForm = GetPropertyValue<string>(element, "embedForm")
                }
            }
        };
        }

        public IModuleViewModel Convert(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            if (_moduleMappings.TryGetValue(element.ContentType.Alias, out var converter))
            {
                return converter(element);
            }

            throw new InvalidOperationException($"No converter found for element type '{element.ContentType.Alias}'.");
        }

        private T? GetPropertyValue<T>(IPublishedElement element, string alias)
        {
            var property = element.GetProperty(alias);
            return property != null ? (T?)property.GetValue() : default;
        }
    }
}
