using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace AleksaPortfolio.Models.Global
{
    public class OpenGraphLayout
    {
        public OpenGraphLayout(string? opengraphTitle, string? opengraphDescription, MediaWithCrops? opengraphImage)
        {
            OpengraphTitle = opengraphTitle;
            OpengraphDescription = opengraphDescription;
            OpengraphImage = opengraphImage;
        }

        public string? OpengraphTitle { get; set; }
        public string? OpengraphDescription { get; set; }
        public MediaWithCrops? OpengraphImage { get; set; }
    }
}
