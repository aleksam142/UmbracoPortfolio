using AleksaPortfolio.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace AleksaPortfolio.Models.Interfaces
{
    public interface IPage
    {
        string PageTitle { get; }

        string OpengraphTitle { get; }
        string OpengraphDescription { get; }
        MediaWithCrops OpengraphImage { get; }
    }
}
