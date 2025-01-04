using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksaPortfolio.Models.ViewModels
{
    public class SkillGroupViewModel : IModuleViewModel
    {
        public string? GroupTitle { get; set; }
        public string? EmbedIcon { get; set; }
        public string[]? Skills { get; set; }
    }
}
