using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace AleksaPortfolio.Models.Global
{
    public class FooterLayout
    {
        public FooterLayout(string? copyrightText, IEnumerable<Link>? links)
        {
            CopyrightText = copyrightText;
            Links = links?.ToArray();
        }

        public string? CopyrightText { get; set; }
        public Link[]? Links { get; set; }
    }
}
