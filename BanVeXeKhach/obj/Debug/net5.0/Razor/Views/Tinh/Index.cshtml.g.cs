#pragma checksum "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feee9b28955cbb48652c0887556a2928aafdc2d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tinh_Index), @"mvc.1.0.view", @"/Views/Tinh/Index.cshtml")]
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
#line 1 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\_ViewImports.cshtml"
using BanVeXeKhach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\_ViewImports.cshtml"
using BanVeXeKhach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feee9b28955cbb48652c0887556a2928aafdc2d3", @"/Views/Tinh/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f63c54e1296b5cd5c73dd0665ec7832b4f7ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Tinh_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanVeXeKhach.Models.Tinh>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bulk_delete_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
  
    ViewBag.Title = "Tỉnh";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <!-- Page Heading -->\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">Tỉnh</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 336, "\"", 373, 1);
#nullable restore
#line 12 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
WriteAttributeValue("", 343, Url.RouteUrl("tinh.them.get"), 343, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success btn-add-new"">
            <i class=""fas fa-fw fa-plus-circle""></i><span> Thêm</span>
        </a>
    </div>

    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách tỉnh</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Mã tỉnh</th>
                            <th>Tên tỉnh</th>
                            <th style=""width: 120px"">Thao tác</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 33 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                         foreach (var tinh in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 36 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                               Write(tinh.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                               Write(tinh.tenTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"max-width: 120px\">\r\n                                    <div class=\"d-flex justify-content-between\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1667, 1);
#nullable restore
#line 40 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
WriteAttributeValue("", 1617, Url.RouteUrl("tinh.sua.get", new { id = tinh.id}), 1617, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-sm mr-2"">
                                            <div class=""d-flex align-items-baseline"">
                                                <i class=""fas fa-pencil-alt""></i>
                                                <span class=""ml-1"">Sửa</span>
                                            </div>
                                        </a>
                                        <a href=""#"" class=""btn btn-danger btn-sm btnDelete"" data-toggle=""modal"" data-target=""#bulk_delete_modal"" data-text=""");
#nullable restore
#line 46 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                                                                                                                                                       Write(tinh.tenTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-value=\"");
#nullable restore
#line 46 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                                                                                                                                                                                  Write(tinh.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                            <div class=""d-flex align-items-baseline"">
                                                <i class=""fas fa-trash""></i>
                                                <span class=""ml-1"">Xóa</span>
                                            </div>
                                        </a>
                                    </div>
                                </td>
                            </tr>
");
#nullable restore
#line 55 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("bulk_delete_modal", async() => {
                WriteLiteral(@"
    <div class=""modal fade"" tabindex=""-1"" id=""bulk_delete_modal"" role=""dialog"" style=""display: none;"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""m-0 font-weight-bold text-primary"">
                        <i class=""fas fa-fw fa-trash-alt""></i> Bạn có chắc là muốn xóa <span id=""bulk_delete_count""></span> không?
                    </h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">×</span></button>
                </div>

                <div class=""modal-body"" id=""delete_modal_body""></div>

                <div class=""modal-footer"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feee9b28955cbb48652c0887556a2928aafdc2d310193", async() => {
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 79 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        <input type=\"submit\" class=\"btn btn-success\" value=\"Có\">\r\n                        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Không</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("js", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"body\").on(\'click\', \'.btnDelete\', function () {\r\n                document.getElementById(\"bulk_delete_form\").action = \"");
#nullable restore
#line 94 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Tinh\Index.cshtml"
                                                                 Write(Url.RouteUrl("tinh.index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" + \"/xoa/\" + this.getAttribute(\"data-value\")\r\n                $(\"#bulk_delete_count\").html(this.getAttribute(\"data-text\"))\r\n            })\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanVeXeKhach.Models.Tinh>> Html { get; private set; }
    }
}
#pragma warning restore 1591