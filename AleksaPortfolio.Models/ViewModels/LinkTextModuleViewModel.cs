using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace AleksaPortfolio.Models.ViewModels
{
    public class LinkTextModuleViewModel : IModuleViewModel
    {
        public Link? Link { get; set; }
        public string? Title { get; set; }
    }
}
