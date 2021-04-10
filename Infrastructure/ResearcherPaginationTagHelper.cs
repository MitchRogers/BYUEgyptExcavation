using BYUEgyptExcavation.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUEgyptExcavation.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-research")]
    public class ResearcherPaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory urlInfo;
        public ResearcherPaginationTagHelper(IUrlHelperFactory uhf)
        {
            urlInfo = uhf;
        }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public PageNumberingInfo PageResearch { get; set; }

        public string PageClass { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlInfo.GetUrlHelper(ViewContext);

            TagBuilder finishedTag = new TagBuilder("div");

            for (int i = 1; i <= PageResearch.NumPages; i++)
            {
                TagBuilder individualTag = new TagBuilder("a");

                individualTag.Attributes["href"] = "/Burials/ResearchIndex/?pagenum=" + i;
                individualTag.AddCssClass(PageClass);
                individualTag.InnerHtml.Append(i.ToString());

                finishedTag.InnerHtml.AppendHtml(individualTag);
            }

            output.Content.AppendHtml(finishedTag.InnerHtml);
        }
    }  
    
}
