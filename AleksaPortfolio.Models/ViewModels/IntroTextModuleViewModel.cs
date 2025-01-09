using AleksaPortfolio.Models.Interfaces;
using AleksaPortfolio.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AleksaPortfolio.Models.ViewModels
{
    public class IntroTextModuleViewModel : IModuleViewModel
    {
        public string? TagText { get; set; }
        public string? SmallTitleText { get; set; }
        public string? LargeTitleText { get; set; }
        public BlockListModel? Links { get; set; }
        public MediaWithCrops? Image { get; set; }
    }
}
