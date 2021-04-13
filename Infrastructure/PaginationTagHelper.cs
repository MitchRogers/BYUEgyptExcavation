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
using BYUEgyptExcavation.Models;

namespace BYUEgyptExcavation.Infrastructure
{

    //build a div with a page-info attribute
    [HtmlTargetElement("div", Attributes = "page-info")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory urlInfo;
        public PaginationTagHelper(IUrlHelperFactory uhf)
        {
            urlInfo = uhf;
        }

        //build the view context used in making tags dynamic
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public PageNumberingInfo PageInfo { get; set; }

        public string PageBtn { get; set; }

        public string Filter { get; set; }

        //build a dictionary for page numbering
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> KeyValuePairs { get; set; } = new Dictionary<string, object>();

        //these are used to hopefully highlight the filters
        public string PageClass { get; set; }
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        //build a process class that will allow us to build our own tags
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //create one div tag to hold all the page information

            IUrlHelper urlHelper = urlInfo.GetUrlHelper(ViewContext);

            TagBuilder finishedTag = new TagBuilder("div");

            //use a loop for the number of pages to make multiple a tags within the div. These will be the actual buttons.
            for (int i = 1; i <= PageInfo.NumPages; i++)
            {
                TagBuilder individualTag = new TagBuilder("a");

                KeyValuePairs["pagenum"] = i;
                individualTag.Attributes["href"] = urlHelper.Action("Index", KeyValuePairs);
                
                if (PageClassesEnabled)
                {
                    individualTag.AddCssClass(PageClass);
                    individualTag.AddCssClass(i == PageInfo.CurrentPage ? PageClassSelected : PageClassNormal);
                }

                
                individualTag.InnerHtml.Append(i.ToString());

                finishedTag.InnerHtml.AppendHtml(individualTag);
            }

            //output the finished tag
            output.Content.AppendHtml(finishedTag.InnerHtml);
        }
    }
}
