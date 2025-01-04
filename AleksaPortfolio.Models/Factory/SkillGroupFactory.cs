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
    public class SkillGroupFactory : ISkillGroupFactory
    {
        public SkillGroupViewModel Create(IPublishedElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new SkillGroupViewModel
            {
                EmbedIcon = GetPropertyValue<string>(element, "icon"),
                GroupTitle = GetPropertyValue<string>(element, "groupTitle"),
                Skills = GetPropertyValue<IEnumerable<string>>(element, "skills")?.ToArray()
            };
        }

        private T? GetPropertyValue<T>(IPublishedElement element, string alias)
        {
            var property = element.GetProperty(alias);
            return property != null ? (T?)property.GetValue() : default;
        }
    }
}
