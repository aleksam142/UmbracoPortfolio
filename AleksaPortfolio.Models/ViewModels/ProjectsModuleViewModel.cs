using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.Blocks;

namespace AleksaPortfolio.Models.ViewModels
{
    public class ProjectsModuleViewModel : IModuleViewModel
    {
        public string? Title { get; set; }
        public BlockListModel? Cards { get; set; }
    }
}
