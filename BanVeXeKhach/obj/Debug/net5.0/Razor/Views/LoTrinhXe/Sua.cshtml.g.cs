#pragma checksum "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d36f79b2cdc3f12fe2591629c604da48302bd34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoTrinhXe_Sua), @"mvc.1.0.view", @"/Views/LoTrinhXe/Sua.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d36f79b2cdc3f12fe2591629c604da48302bd34", @"/Views/LoTrinhXe/Sua.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f63c54e1296b5cd5c73dd0665ec7832b4f7ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_LoTrinhXe_Sua : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BanVeXeKhach.Models.NhaXe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
  
    ViewBag.Title = "Sửa nhà xe";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <!-- Page Heading -->\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">Thông tin nhà xe</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 342, "\"", 378, 1);
#nullable restore
#line 12 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
WriteAttributeValue("", 349, Url.RouteUrl("nha_xe.index"), 349, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\"><i class=\"fa fa-arrow-left\"></i> Quay lại</a>\r\n    </div>\r\n\r\n    <!-- DataTales Example -->\r\n");
#nullable restore
#line 16 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
     using (Html.BeginForm("Sua", "NhaXe", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                <div class=""card shadow mb-4"">
                    <div class=""card-body"">
                        <div class=""content table-responsive content"">
                            <div class=""panel-body"">
                                <div class=""form-group"">
                                    <label for=""bienSo"">Biển số</label>
                                    ");
#nullable restore
#line 27 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.TextBoxFor(nha_xe => nha_xe.bienSo, new { @class = "form-control", @required = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 28 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.ValidationMessageFor(nha_xe => nha_xe.bienSo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"tenNhaXe\">Tên nhà xe</label>\r\n                                    ");
#nullable restore
#line 33 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.TextBoxFor(nha_xe => nha_xe.tenNhaXe, new { @class = "form-control", @required = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 34 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.ValidationMessageFor(nha_xe => nha_xe.tenNhaXe, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"soDienThoai\">Số điện thoại</label>\r\n                                    ");
#nullable restore
#line 39 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.TextBoxFor(nha_xe => nha_xe.soDienThoai, new { @class = "form-control", @required = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 40 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.ValidationMessageFor(nha_xe => nha_xe.soDienThoai, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"soGheNgoi\">Số ghế ngồi</label>\r\n                                    ");
#nullable restore
#line 45 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.TextBoxFor(nha_xe => nha_xe.soGheNgoi, new { @type = "number", @class = "form-control", @required = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 46 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.ValidationMessageFor(nha_xe => nha_xe.soGheNgoi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"soGheNam\">Số ghế nằm</label>\r\n                                    ");
#nullable restore
#line 51 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.TextBoxFor(nha_xe => nha_xe.soGheNam, new { @type = "number", @class = "form-control", @required = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 52 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.ValidationMessageFor(nha_xe => nha_xe.soGheNam, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"taiTrongMoiKhach\">Tải trọng mỗi khách</label>\r\n                                    ");
#nullable restore
#line 57 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.TextBoxFor(nha_xe => nha_xe.taiTrongMoiKhach, new { @type = "number", @class = "form-control", @required = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 58 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.ValidationMessageFor(nha_xe => nha_xe.taiTrongMoiKhach, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"thoiGianDi\">Thời gian đi</label>\r\n                                    ");
#nullable restore
#line 63 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.TextBoxFor(nha_xe => nha_xe.thoiGianDi, new { @type = "time", @class = "form-control", @required = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 64 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
                               Write(Html.ValidationMessageFor(nha_xe => nha_xe.thoiGianDi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"mb-3\">\r\n            <input type=\"submit\" class=\"btn btn-success btnSave\" value=\"Lưu thông tin\">\r\n            <input type=\"reset\" class=\"btn btn-secondary btnReset\" value=\"Nhập lại\">\r\n        </div>\r\n");
#nullable restore
#line 77 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\LoTrinhXe\Sua.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BanVeXeKhach.Models.NhaXe> Html { get; private set; }
    }
}
#pragma warning restore 1591