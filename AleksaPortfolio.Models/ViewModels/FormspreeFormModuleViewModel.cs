using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksaPortfolio.Models.ViewModels
{
    public class FormspreeFormModuleViewModel : IModuleViewModel
    {
        public string? FormTitle { get; set; }
        public string? FormDescription { get; set; }
        public string? EmbedForm { get; set; }
    }
}
