using AleksaPortfolio.Models.Interfaces;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Cms.Core.Models.Blocks;

namespace AleksaPortfolio.Models.Helpers
{
    public static class ModuleRenderingHelper
    {
        public static async Task<IHtmlContent> RenderModuleAsync(this IHtmlHelper htmlHelper, BlockListItem module, IModuleConverter moduleConverter)
        {
            if (module == null || module.Content == null)
            {
                return HtmlString.Empty;
            }

            var viewModel = moduleConverter.ConvertViewModel(module.Content);
            var partialViewPath = $"~/Views/Partials/blocklist/Components/{module.Content.ContentType.Alias}.cshtml";

            return await htmlHelper.PartialAsync(partialViewPath, viewModel);
        }
    }
}
