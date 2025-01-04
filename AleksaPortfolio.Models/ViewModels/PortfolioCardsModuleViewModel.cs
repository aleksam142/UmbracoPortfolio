using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;

namespace AleksaPortfolio.Models.ViewModels
{
    public class PortfolioCardsModuleViewModel : IModuleViewModel
    {
        public BlockListModel? Cards { get; set; }
        public string? TitleColor { get; set; }
        public IEnumerable<Link>? PortfolioLinks { get; set; }
        public string? Title { get; set; }
    }
}
