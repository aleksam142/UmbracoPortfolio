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
        private readonly ISocialIconFactory _socialIconFactory;
        private readonly ISocialModuleFactory _socialModuleFactory;
        private readonly ISimpleHeadingModuleFactory _simpleHeadingFactory;
        private readonly IPortfolioCardsModuleFactory _portfolioCardsModuleFactory;
        private readonly IPortfolioListingCardFactory _portfolioListingCardFactory;
        private readonly ISkillsModuleFactory _skillsModuleFactory;
        private readonly ISkillGroupFactory _skillGroupFactory;
        private readonly ILinkTextModuleFactory _linkTextFactory;
        private readonly IProjectCardFactory _projectCardFactory;
        private readonly IProjectsModuleFactory _projectsModuleFactory;

        public ModuleConverter(IFormspreeFormModuleFactory formspreeFormModuleFactory,
                                IIntroTextModuleFactory introFactory,
                                IIntroLinkFactory introLinkFactory,
                                ISocialIconFactory socialIconFactory,
                                ISocialModuleFactory socialModuleFactory,
                                ISimpleHeadingModuleFactory simpleHeadingFactory,
                                IPortfolioCardsModuleFactory portfolioCardsModuleFactory,
                                IPortfolioListingCardFactory portfolioListingCardFactory,
                                ISkillsModuleFactory skillsModuleFactory,
                                ISkillGroupFactory skillGroupFactory,
                                ILinkTextModuleFactory linkTextFactory,
                                IProjectCardFactory projectCardFactory,
                                IProjectsModuleFactory projectsModuleFactory)
        {
            _formspreeFormModuleFactory = formspreeFormModuleFactory;
            _introFactory = introFactory;
            _introLinkFactory = introLinkFactory;
            _socialIconFactory = socialIconFactory;
            _socialModuleFactory = socialModuleFactory;
            _simpleHeadingFactory = simpleHeadingFactory;
            _portfolioCardsModuleFactory = portfolioCardsModuleFactory;
            _portfolioListingCardFactory = portfolioListingCardFactory;
            _skillsModuleFactory = skillsModuleFactory;
            _skillGroupFactory = skillGroupFactory;
            _linkTextFactory = linkTextFactory;
            _projectCardFactory = projectCardFactory;
            _projectsModuleFactory = projectsModuleFactory;
        }

        public IModuleViewModel ConvertViewModel(IPublishedElement element)
        {
            IModuleViewModel viewModel = element.ContentType.Alias switch
            {
                "formspreeContactFormModule" => _formspreeFormModuleFactory.Create(element),
                "portfolioCardsModule" => _portfolioCardsModuleFactory.Create(element),
                "portfolioListingCard" => _portfolioListingCardFactory.Create(element),
                "introTextModule" => _introFactory.Create(element),
                "introLink" => _introLinkFactory.Create(element),
                "socialIcon" => _socialIconFactory.Create(element),
                "socialModule" => _socialModuleFactory.Create(element),
                "simpleHeadingModule" => _simpleHeadingFactory.Create(element),
                "skillsModule" => _skillsModuleFactory.Create(element),
                "skillGroup" => _skillGroupFactory.Create(element),
                "linkTextModule" => _linkTextFactory.Create(element),
                "projectCard" => _projectCardFactory.Create(element),
                "projectsModule" => _projectsModuleFactory.Create(element),
                _ => throw new InvalidOperationException($"No factory found for element type '{element.ContentType.Alias}'.")
            };

            return viewModel;
        }
    }
}
