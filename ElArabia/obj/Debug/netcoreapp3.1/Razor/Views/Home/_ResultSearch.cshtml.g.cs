#pragma checksum "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_ResultSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "690e427ba45ba846cc9503686ba6cdb84ac93649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ResultSearch), @"mvc.1.0.view", @"/Views/Home/_ResultSearch.cshtml")]
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
#nullable restore
#line 1 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\_ViewImports.cshtml"
using ElArabia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\_ViewImports.cshtml"
using ElArabia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"690e427ba45ba846cc9503686ba6cdb84ac93649", @"/Views/Home/_ResultSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3bfe41f6ffef11b095f09c0fb5a725ec9f55c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ResultSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElArabia.ViewModel.ItemsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_ResultSearch.cshtml"
  
    ViewBag.Title = "Result Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid padding\">\r\n    <div class=\"row padding\">\r\n");
#nullable restore
#line 10 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_ResultSearch.cshtml"
         foreach (var item in Model.products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 col-sm-6\">\r\n                <div class=\"product-grid3\">\r\n                    <div class=\"product-image3\">\r\n                        <a href=\"#\">\r\n                            <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 494, "\"", 524, 1);
#nullable restore
#line 16 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_ResultSearch.cshtml"
WriteAttributeValue("", 500, Url.Content(item.Image), 500, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                        <ul class=\"social\">\r\n                            <li><a");
            BeginWriteAttribute("onclick", " onclick=\"", 637, "\"", 718, 3);
            WriteAttributeValue("", 647, "location.href=\'", 647, 15, true);
#nullable restore
#line 19 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_ResultSearch.cshtml"
WriteAttributeValue("", 662, Url.Action("_DetialsItem", "Home" , new {id =item.Id}), 662, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 717, "\'", 717, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-bag\"></i></a></li>\r\n                        </ul>\r\n\r\n                    </div>\r\n                    <div class=\"product-content\">\r\n                        <h3 class=\"title\"><a href=\"#\">");
#nullable restore
#line 24 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_ResultSearch.cshtml"
                                                 Write(item.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_ResultSearch.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<script>\r\n    var ItemId = $(\"#ItemId\").val();\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElArabia.ViewModel.ItemsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591