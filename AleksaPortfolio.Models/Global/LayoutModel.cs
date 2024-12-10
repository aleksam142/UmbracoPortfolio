using AleksaPortfolio.Models.Interfaces;
using AleksaPortfolio.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Extensions;

namespace AleksaPortfolio.Models.Global
{
    public class LayoutModel
    {
        private readonly IPublishedContent _content;

        public LayoutModel(IPublishedContent content)
        {
            _content = content;
        }

        private Homepage Home => _content.Root() as Homepage;
        private IPage CurrentPage => _content as IPage;

        public HeaderLayout Header => new(Home?.MainHeaderLink, Home?.HeaderLinks);
        public FooterLayout LinkUrl => new(Home?.CopyrightText, Home?.FooterLinks);
    }
}
