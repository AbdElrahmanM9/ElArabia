#pragma checksum "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de54464568f8ee305d8ac47539dc6eb05edc17d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__DetialsByDetial), @"mvc.1.0.view", @"/Views/Admin/_DetialsByDetial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de54464568f8ee305d8ac47539dc6eb05edc17d6", @"/Views/Admin/_DetialsByDetial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3bfe41f6ffef11b095f09c0fb5a725ec9f55c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__DetialsByDetial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElArabia.ViewModel.ItemsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
  
    ViewBag.Title = "More Detials";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n</style>\r\n");
#nullable restore
#line 9 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
  
    var DetailId = Model.ProductsDetail.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-12 col-sm-push-3"">
        <div class=""catalog"">
            <div class=""detail"">
                <div class=""unit"">
                    <div class=""position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light my-5"">

                        <img class=""pic-1 m-5""");
            BeginWriteAttribute("src", " src=\"", 534, "\"", 580, 1);
#nullable restore
#line 19 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
WriteAttributeValue("", 540, Url.Content(Model.ProductsDetail.Image), 540, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" height: 300px; border-radius: 21px 21px 0 0;\">\r\n                        <h1 class=\"display-4 font-weight-normal\">");
#nullable restore
#line 20 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                                                            Write(Model.ProductsDetail.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"lead font-weight-normal\">");
#nullable restore
#line 21 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                                                      Write(Model.ProductsDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                         if (@Model.ProductsDetail.Prepare != "#")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-outline-secondary\" src=\"#\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1019, "\"", 1055, 1);
#nullable restore
#line 24 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
WriteAttributeValue("", 1026, Model.ProductsDetail.Prepare, 1026, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">طريقة التحضير</a>\r\n");
#nullable restore
#line 25 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-outline-secondary\" src=\"#\"");
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1268, 1);
#nullable restore
#line 28 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
WriteAttributeValue("", 1239, Model.ProductsDetail.Prepare, 1239, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">طريقة التحضير</a>\r\n");
#nullable restore
#line 29 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 31 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                     using (Html.BeginForm("AddPrepareIMG", "Admin", FormMethod.Post, new { enctype = "multipart/form-data", id = "AddForm" }))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bd-example5 my-5\" id=\"ItemsTable\">\r\n                            ");
#nullable restore
#line 35 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            <div class=""form-group"">
                                <div class=""col-md-10"">
                                    <input type=""file"" name=""upload"" class=""control-label col-md-4 subscribe btn btn-light btn-lg btn-block"" />
                                </div>
                            </div>
                            <input type=""hidden"" ");
#nullable restore
#line 42 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                                            Write(Html.EditorFor(model => model.ProductsDetails.FirstOrDefault().Id, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" />

                            <div class=""form-group"">
                                <div class=""col-md-offset-2 col-md-10"">
                                    <input type=""submit"" value=""Save"" class=""btn btn-success"" />
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 50 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                     if (Model.PrepareIMG.Count != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""summary"">
                            <div class=""description"">

                                <div class=""col-xs-12 my-5"">
                                    <div class=""lined-div"">
                                        <h4><span>بعد التحضير</span></h4>
                                        <p></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
");
#nullable restore
#line 66 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                             foreach (var item in Model.PrepareIMG)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-sm-6 col-md-4 col-lg-3 cheese-item text-center"">
                                    <div class=""cheese-image"">
                                        <div class=""cheese-image-border"">
                                            <a>
                                                <img style=""border: 0px;"" class=""tweet_thumb""");
            BeginWriteAttribute("src", " src=\"", 3705, "\"", 3733, 1);
#nullable restore
#line 72 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
WriteAttributeValue("", 3711, Url.Content(item.IMG), 3711, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 77 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 80 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

</div>

<div class=""col-xs-12 my-5"">
    <div class=""lined-div"">
        <h4><span>منتجاتنا</span></h4>
        <p></p>
    </div>
</div>

<div class=""DivFore2"">
    <div class=""container"">
        <div class=""carousel5"">
");
#nullable restore
#line 99 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
             foreach (var item in Model.ProductsDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4499, "\"", 4609, 3);
            WriteAttributeValue("", 4509, "location.href=\'", 4509, 15, true);
#nullable restore
#line 103 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
WriteAttributeValue("", 4524, Url.Action("_DetialsByDetial", "Admin" , new {NameEn = item.NameEn , Id = item.Id}), 4524, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4608, "\'", 4608, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"pic-1\"");
            BeginWriteAttribute("src", " src=\"", 4659, "\"", 4689, 1);
#nullable restore
#line 104 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
WriteAttributeValue("", 4665, Url.Content(item.Image), 4665, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-content\">\r\n                            <div class=\"card-title\"><h3>");
#nullable restore
#line 109 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
                                                   Write(item.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 113 "G:\AbdElrahman\Project\ElArabia\ElArabia\Views\Admin\_DetialsByDetial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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