#pragma checksum "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc91c061748d4acca56a76a84b8a730018b10b0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__EditModelThree), @"mvc.1.0.view", @"/Views/Admin/_EditModelThree.cshtml")]
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
#line 1 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\_ViewImports.cshtml"
using ElArabia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\_ViewImports.cshtml"
using ElArabia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc91c061748d4acca56a76a84b8a730018b10b0c", @"/Views/Admin/_EditModelThree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3bfe41f6ffef11b095f09c0fb5a725ec9f55c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__EditModelThree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElArabia.Models.HomeModelThree>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
  
    ViewBag.Title = "Edit Model";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"my-3\">Edit Product</h2>\r\n\r\n");
#nullable restore
#line 9 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
 using (Html.BeginForm("SaveModelThree", "Admin", FormMethod.Post, new { enctype = "multipart/form-data", id = "AddForm" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bd-example5 my-5\" id=\"ItemsTable\">\r\n\r\n        ");
#nullable restore
#line 15 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
       Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger NameEn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 26 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
       Write(Html.LabelFor(model => model.IMG, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <input type=\"file\" name=\"upload\" class=\"control-label col-md-4 subscribe btn btn-light btn-lg btn-block\" />\r\n                ");
#nullable restore
#line 29 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
           Write(Html.ValidationMessageFor(model => model.IMG, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 33 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 35 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-1\">\r\n                ");
#nullable restore
#line 42 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
           Write(Html.EditorFor(model => model.Id, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-offset-2 col-md-10 my-2\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 49 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_EditModelThree.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElArabia.Models.HomeModelThree> Html { get; private set; }
    }
}
#pragma warning restore 1591
