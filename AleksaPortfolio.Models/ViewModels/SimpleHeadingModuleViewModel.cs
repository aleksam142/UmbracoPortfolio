using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksaPortfolio.Models.ViewModels
{
    public class SimpleHeadingModuleViewModel : IModuleViewModel
    {
        public string? Heading { get; set; }
    }
}
