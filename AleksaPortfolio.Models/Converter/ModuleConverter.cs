using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AleksaPortfolio.Models.Converter
{
    public class ModuleConverter : IModuleConverter
    {
        private readonly IFormspreeFormModuleFactory _formspreeFormModuleFactory;
        private readonly IIntroTextModuleFactory _introFactory;
        private readonly IIntroLinkFactory _introLinkFactory;

        public ModuleConverter(IFormspreeFormModuleFactory formspreeFormModuleFactory,
                                IIntroTextModuleFactory introFactory,
                                IIntroLinkFactory introLinkFactory)
        {
            _formspreeFormModuleFactory = formspreeFormModuleFactory;
            _introFactory = introFactory;
            _introLinkFactory = introLinkFactory;
        }

        public IModuleViewModel ConvertViewModel(IPublishedElement element)
        {
            IModuleViewModel viewModel = element.ContentType.Alias switch
            {
                "formspreeContactFormModule" => _formspreeFormModuleFactory.Create(element),
                "introTextModule" => _introFactory.Create(element),
                "introLink" => _introLinkFactory.Create(element),
                _ => throw new InvalidOperationException($"No factory found for element type '{element.ContentType.Alias}'.")
            };

            return viewModel;
        }
    }
}
