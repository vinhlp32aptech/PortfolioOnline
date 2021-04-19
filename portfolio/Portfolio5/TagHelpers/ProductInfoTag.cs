using Portfolio5.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.TagHelpers
{
    [HtmlTargetElement("productinfo", TagStructure = TagStructure.NormalOrSelfClosing)]

    public class ProductInfoTag : TagHelper
    {

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        private IHtmlHelper htmlHelper;

        public ProductInfoTag(IHtmlHelper _htmlHelper)
        {
            this.htmlHelper = _htmlHelper;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (htmlHelper as IViewContextAware).Contextualize(ViewContext);

           // htmlHelper.ViewBag.products = productService.Find();

            output.TagName = "";
            output.Content.SetHtmlContent(await htmlHelper.PartialAsync("TagHelpers/Product/Index"));
        }
    }
}
