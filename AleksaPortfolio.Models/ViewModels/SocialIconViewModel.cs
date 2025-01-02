using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace AleksaPortfolio.Models.ViewModels
{
    public class SocialIconViewModel : IModuleViewModel
    {
        public string? SocialMedia { get; set; }
        public Link? Link { get; set; }
    }
}
