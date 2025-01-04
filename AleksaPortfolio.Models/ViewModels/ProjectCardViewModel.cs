using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace AleksaPortfolio.Models.ViewModels
{
    public class ProjectCardViewModel : IModuleViewModel
    {
        public MediaWithCrops? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
