#pragma checksum "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163f9e76d4e787a1449923cfb324f061e1d5f4d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__AllProducts), @"mvc.1.0.view", @"/Views/Admin/_AllProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163f9e76d4e787a1449923cfb324f061e1d5f4d4", @"/Views/Admin/_AllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3bfe41f6ffef11b095f09c0fb5a725ec9f55c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__AllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElArabia.ViewModel.ItemsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("svg-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/018-delete.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 17%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml"
  
    ViewBag.Title = "All Product";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid padding my-lg-5\">\r\n    <div class=\"row padding\">\r\n");
#nullable restore
#line 10 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml"
         foreach (var item in Model.products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 col-sm-6 my-lg-5\">\r\n                <div class=\"product-grid3\">\r\n                    <div class=\"product-image3\">\r\n                        <a href=\"#\">\r\n                            <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 513, "\"", 543, 1);
#nullable restore
#line 16 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml"
WriteAttributeValue("", 519, Url.Content(item.Image), 519, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;\">\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"product-content\">\r\n                        <h3 class=\"title\">");
#nullable restore
#line 20 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml"
                                     Write(item.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <ul class=\"social\">\r\n                        <li>\r\n                            <a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "163f9e76d4e787a1449923cfb324f061e1d5f4d46334", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 915, "location.href=\'", 915, 15, true);
#nullable restore
#line 25 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml"
AddHtmlAttributeValue("", 930, Url.Action("DeleteItem", "Admin", new { ProductId = item.Id }), 930, 63, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 993, "\'", 993, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1146, "\"", 1234, 3);
            WriteAttributeValue("", 1156, "location.href=\'", 1156, 15, true);
#nullable restore
#line 27 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml"
WriteAttributeValue("", 1171, Url.Action("_EditItem", "Admin", new { ProductId = item.Id }), 1171, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1233, "\'", 1233, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa-solid fa-pen-to-square\" style=\"width:20%\"></i>\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_AllProducts.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElArabia.ViewModel.ItemsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
