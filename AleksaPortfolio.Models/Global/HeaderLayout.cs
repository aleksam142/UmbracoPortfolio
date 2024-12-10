using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace AleksaPortfolio.Models.Global
{
    public class HeaderLayout
    {
        public HeaderLayout(Link? mainLink, IEnumerable<Link>? links)
        {
            MainLink = mainLink;
            Links = links;
        }

        public Link? MainLink { get; set; }
        public IEnumerable<Link>? Links { get; set; }
    }
}
