#pragma checksum "C:\Users\SON\Source\Repos\PortfolioOnline\PortfolioOnline\Areas\Admin\Views\Follow\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d911aa83bdcb5f7830a663eefe62167a653bef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Follow_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Follow/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d911aa83bdcb5f7830a663eefe62167a653bef2", @"/Areas/Admin/Views/Follow/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Follow_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\SON\Source\Repos\PortfolioOnline\PortfolioOnline\Areas\Admin\Views\Follow\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<br />
<br />
<div class=""container"">
    <h2>FOLLOWER</h2>
    <button type=""button"" class=""btn btn-success""><i class=""fas fa-plus"">ADD</i></button>

    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Id Follow</th>
                <th>Id Account</th>
                <th>Num Of Follow</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>John</td>
                <td>Doe</td>
                <td>john@example.com</td>
                <td>
                    <button type=""button"" class=""btn btn-success""><i class=""fas fa-edit""></i></button>
                    <button type=""button"" class=""btn btn-danger""><i class=""far fa-trash-alt""></i></button>
                </td>
            </tr>
            <tr>
                <td>Mary</td>
                <td>Moe</td>
                <td>mary@example.com</td>
                <td>
                    <button type=");
            WriteLiteral(@"""button"" class=""btn btn-success""><i class=""fas fa-edit""></i></button>
                    <button type=""button"" class=""btn btn-danger""><i class=""far fa-trash-alt""></i></button>
                </td>
            </tr>
            <tr>
                <td>July</td>
                <td>Dooley</td>
                <td>july@example.com</td>
                <td>
                    <button type=""button"" class=""btn btn-success""><i class=""fas fa-edit""></i></button>
                    <button type=""button"" class=""btn btn-danger""><i class=""far fa-trash-alt""></i></button>
                </td>
            </tr>
        </tbody>
    </table>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
