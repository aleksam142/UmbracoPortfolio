using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.Blocks;

namespace AleksaPortfolio.Models.ViewModels
{
    public class SocialModuleViewModel : IModuleViewModel
    {
        public string? MainTitle { get; set; }
        public string? SmallTitle { get; set; }
        public string? ModuleText { get; set; }
        public BlockListModel? SocialLinks { get; set; }
    }
}
