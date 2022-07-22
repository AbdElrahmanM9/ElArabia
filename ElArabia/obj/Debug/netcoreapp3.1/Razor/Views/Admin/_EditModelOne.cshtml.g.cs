#pragma checksum "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9529da3d473acb2207ea1496f89cc91cc235b9f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__EditModelOne), @"mvc.1.0.view", @"/Views/Admin/_EditModelOne.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9529da3d473acb2207ea1496f89cc91cc235b9f9", @"/Views/Admin/_EditModelOne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3bfe41f6ffef11b095f09c0fb5a725ec9f55c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__EditModelOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElArabia.Models.HomeModelOne>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
  
    ViewBag.Title = "Edit Model";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"my-3\">Edit Product</h2>\r\n\r\n");
#nullable restore
#line 9 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
 using (Html.BeginForm("SaveModelOne", "Admin", FormMethod.Post, new { enctype = "multipart/form-data", id = "AddForm" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bd-example5 my-5\" id=\"ItemsTable\">\r\n\r\n        ");
#nullable restore
#line 15 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
       Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger NameEn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 26 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
       Write(Html.LabelFor(model => model.IMG, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <input type=\"file\" name=\"upload\" class=\"control-label col-md-4 subscribe btn btn-light btn-lg btn-block\" />\r\n                ");
#nullable restore
#line 29 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.IMG, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 33 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 35 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-1\">\r\n                ");
#nullable restore
#line 42 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
           Write(Html.EditorFor(model => model.Id, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-offset-2 col-md-10 my-2\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 49 "D:\ASP.NET\Projects\ElArabia\ElArabia\Views\Admin\_EditModelOne.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElArabia.Models.HomeModelOne> Html { get; private set; }
    }
}
#pragma warning restore 1591