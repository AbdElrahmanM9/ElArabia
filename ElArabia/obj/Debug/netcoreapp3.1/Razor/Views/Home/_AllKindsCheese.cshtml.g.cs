#pragma checksum "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_AllKindsCheese.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c38baf7dc597293ded796fb688d22d922530a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__AllKindsCheese), @"mvc.1.0.view", @"/Views/Home/_AllKindsCheese.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c38baf7dc597293ded796fb688d22d922530a4d", @"/Views/Home/_AllKindsCheese.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3bfe41f6ffef11b095f09c0fb5a725ec9f55c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__AllKindsCheese : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ElArabia.Models.Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_AllKindsCheese.cshtml"
  
    ViewBag.Title = "All Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid padding my-lg-5\">\r\n    <div class=\"row padding\">\r\n");
#nullable restore
#line 10 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_AllKindsCheese.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 col-sm-6 my-lg-5\">\r\n                <div class=\"product-grid3\">\r\n                    <div class=\"product-image3\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 434, "\"", 524, 3);
            WriteAttributeValue("", 444, "location.href=\'", 444, 15, true);
#nullable restore
#line 15 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_AllKindsCheese.cshtml"
WriteAttributeValue("", 459, Url.Action("_MoreDetials", "Home" , new {NameEn = item.NameEn}), 459, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 523, "\'", 523, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 574, "\"", 604, 1);
#nullable restore
#line 16 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_AllKindsCheese.cshtml"
WriteAttributeValue("", 580, Url.Content(item.Image), 580, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;\">\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"product-content\">\r\n                        <h3 class=\"title\">");
#nullable restore
#line 20 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_AllKindsCheese.cshtml"
                                     Write(item.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Home\_AllKindsCheese.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ElArabia.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
