using AleksaPortfolio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksaPortfolio.Models.ViewModels
{
    public class PortfolioListingCardViewModel : IModuleViewModel
    {
        public string? ToDate { get; set; }
        public string? FromDate { get; set; }
        public string? DateColor { get; set; }
        public string? Position { get; set; }
        public string? Company { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
    }
}
