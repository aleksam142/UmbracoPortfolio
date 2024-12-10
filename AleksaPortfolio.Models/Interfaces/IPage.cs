using AleksaPortfolio.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksaPortfolio.Models.Interfaces
{
    public interface IPage
    {
        string PageTitle { get; }

        string OpengraphTitle { get; }
        string OpengraphDescription { get; }
        Image OpengraphImage { get; }
    }
}
