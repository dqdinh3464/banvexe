#pragma checksum "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25bdb64da57486e018ad2bcc3e442638e0a81276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25bdb64da57486e018ad2bcc3e442638e0a81276", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f63c54e1296b5cd5c73dd0665ec7832b4f7ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bdb64da57486e018ad2bcc3e442638e0a812763562", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 240, "\"", 281, 5);
#nullable restore
#line 7 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 250, ViewData["Title"], 250, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 268, "-", 269, 2, true);
                WriteAttributeValue(" ", 270, "Đặt", 271, 4, true);
                WriteAttributeValue(" ", 274, "vé", 275, 3, true);
                WriteAttributeValue(" ", 277, "xe<", 278, 4, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\"");
                BeginWriteAttribute("href", " href=\"", 305, "\"", 345, 1);
#nullable restore
#line 8 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 312, Url.Content("~/images/logo.png"), 312, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"image/ico\" />\r\n\r\n    <title>");
#nullable restore
#line 10 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Đặt vé xe</title>\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 432, "\"", 511, 1);
#nullable restore
#line 12 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 439, Url.Content("~/lib/sb-admin-2/vendor/fontawesome-free/css/all.min.css"), 439, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\" rel=\"stylesheet\">\r\n\r\n    <!-- Custom styles for this template-->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 750, "\"", 808, 1);
#nullable restore
#line 16 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 757, Url.Content("~/lib/sb-admin-2/css/sb-admin-2.css"), 757, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 838, "\"", 925, 1);
#nullable restore
#line 17 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 845, Url.Content("~/lib/sb-admin-2/vendor/datatables/dataTables.bootstrap4.min.css"), 845, 80, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n\r\n    <!-- Select2-->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 978, "\"", 1030, 1);
#nullable restore
#line 20 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 985, Url.Content("~/lib/select2/css/select2.css"), 985, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <script");
                BeginWriteAttribute("href", " href=\"", 1062, "\"", 1109, 1);
#nullable restore
#line 21 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1069, Url.Content("~/lib/select2/select2.js"), 1069, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <!-- Toastr-->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1153, "\"", 1192, 1);
#nullable restore
#line 24 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1160, Url.Content("~/css/toastr.css"), 1160, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bdb64da57486e018ad2bcc3e442638e0a812768936", async() => {
                WriteLiteral(@"
    <div id=""wrapper"">
        <!-- Sidebar -->
        <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">
            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center""");
                BeginWriteAttribute("href", " href=\"", 1523, "\"", 1557, 1);
#nullable restore
#line 31 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1530, Url.RouteUrl("home.index"), 1530, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <img width=\"35\" height=\"auto\"");
                BeginWriteAttribute("src", " src=\"", 1606, "\"", 1645, 1);
#nullable restore
#line 32 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1612, Url.Content("~/images/logo.png"), 1612, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""bg-white rounded-circle"" />
                <div class=""sidebar-brand-text mx-3"">Quản lý đặt vé xe</div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Nav Item - Dashboard -->
            <li class=""nav-item active"">
                <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 1980, "\"", 2014, 1);
#nullable restore
#line 41 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 1987, Url.RouteUrl("home.index"), 1987, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <i class=""fas fa-home""></i>
                    <span>Trang chủ</span>
                </a>
            </li>

            <hr class=""sidebar-divider"">
            <!-- Heading -->
            <div class=""sidebar-heading"">
                Quản lý
            </div>
            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2437, "\"", 2471, 1);
#nullable restore
#line 54 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 2444, Url.RouteUrl("tinh.index"), 2444, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <i class=\"fas fa-fw fa-flag-usa\"></i>\r\n                    <span>Quản lý tỉnh</span>\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 2694, "\"", 2730, 1);
#nullable restore
#line 61 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 2701, Url.RouteUrl("nha_xe.index"), 2701, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <i class=\"fas fa-fw fa-building\"></i>\r\n                    <span>Quản lý nhà xe</span>\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 2955, "\"", 2996, 1);
#nullable restore
#line 68 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 2962, Url.RouteUrl("lo_trinh_xe.index"), 2962, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <i class=""fas fa-fw fa-list""></i>
                    <span>Danh sách tỉnh xe đi qua</span>
                </a>
            </li>

            <hr class=""sidebar-divider"">

            <!-- Heading -->
            <div class=""sidebar-heading"">
                Báo cáo
            </div>
            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"" data-toggle=""collapse"" data-target=""#collapseBaoCao"" aria-expanded=""false"" aria-controls=""collapseBaoCao"">
                    <i class=""fas fa-fw fa-chart-area""></i>
                    <span>Báo cáo</span>
                </a>
                <div id=""collapseBaoCao"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
                    <div class=""py-2 collapse-inner rounded"">
                        <a class=""collapse-item""");
                BeginWriteAttribute("href", " href=\"", 3919, "\"", 3926, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-fw fa-users\"></i> Đặt vé theo nhóm</a>\r\n                        <a class=\"collapse-item\"");
                BeginWriteAttribute("href", " href=\"", 4033, "\"", 4040, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fas fa-fw fa-bus""></i> Đặt vé theo xe</a>
                    </div>
                </div>
            </li>

            <hr class=""sidebar-divider"">

            <!-- Sidebar Toggler (Sidebar) -->
            <div class=""text-center d-none d-md-inline"">
                <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
            </div>
        </ul>
        <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">
            <!-- Main Content -->
            <div id=""content"">
                <!-- Topbar -->
                <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">
                    <!-- Sidebar Toggle (Topbar) -->
                    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                        <i class=""fa fa-bars""></i>
                    </button>

                    <!-- Topbar Navbar -->
      ");
                WriteLiteral(@"              <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item dropdown no-arrow"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Douglas McGee</span>
                                <img class=""img-profile rounded-circle""");
                BeginWriteAttribute("src", " src=\"", 5533, "\"", 5594, 1);
#nullable restore
#line 118 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 5539, Url.Content("~/lib/sb-admin-2/img/undraw_profile.svg"), 5539, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </a>
                            <!-- Dropdown - User Information -->
                            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Đăng xuất
                                </a>
                            </div>
                        </li>
                    </ul>
                </nav>

                ");
#nullable restore
#line 131 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            </div>

            <!-- Footer -->
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Your Website 2021</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->

        </div>
        <!-- End of Content Wrapper -->
        <!-- Logout Modal-->
        <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Bạn có chắc là muốn đăng xuất?</h5>
                        <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                            <span ar");
                WriteLiteral(@"ia-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body""></div>
                    <div class=""modal-footer"">
                        <a class=""btn btn-primary"" href=""/Login/Index"">Đăng xuất</a>
                        <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    </div>
                </div>
            </div>
        </div>

        ");
#nullable restore
#line 166 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
   Write(RenderSection("bulk_delete_modal", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Scroll to Top Button-->\r\n        <a class=\"scroll-to-top rounded\" href=\"#page-top\">\r\n            <i class=\"fas fa-angle-up\"></i>\r\n        </a>\r\n    </div>\r\n\r\n    <!-- Bootstrap core JavaScript-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8069, "\"", 8135, 1);
#nullable restore
#line 175 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 8075, Url.Content("~/lib/sb-admin-2/vendor/jquery/jquery.min.js"), 8075, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8159, "\"", 8241, 1);
#nullable restore
#line 176 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 8165, Url.Content("~/lib/sb-admin-2/vendor/bootstrap/js/bootstrap.bundle.min.js"), 8165, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <!-- Select2-->\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.8/js/select2.min.js\" defer></script>\r\n\r\n    <!-- Core plugin JavaScript-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8432, "\"", 8512, 1);
#nullable restore
#line 182 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 8438, Url.Content("~/lib/sb-admin-2/vendor/jquery-easing/jquery.easing.min.js"), 8438, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <!-- Custom scripts for all pages-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8580, "\"", 8639, 1);
#nullable restore
#line 185 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 8586, Url.Content("~/lib/sb-admin-2/js/sb-admin-2.min.js"), 8586, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <!-- Page level plugins -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8698, "\"", 8765, 1);
#nullable restore
#line 188 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 8704, Url.Content("~/lib/sb-admin-2/vendor/chart.js/Chart.min.js"), 8704, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <!-- Page level custom scripts -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8831, "\"", 8896, 1);
#nullable restore
#line 191 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 8837, Url.Content("~/lib/sb-admin-2/js/demo/chart-area-demo.js"), 8837, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8920, "\"", 8984, 1);
#nullable restore
#line 192 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 8926, Url.Content("~/lib/sb-admin-2/js/demo/chart-pie-demo.js"), 8926, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n\r\n    <!-- Page level plugins -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 9045, "\"", 9126, 1);
#nullable restore
#line 196 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9051, Url.Content("~/lib/sb-admin-2/vendor/datatables/jquery.dataTables.min.js"), 9051, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 9150, "\"", 9235, 1);
#nullable restore
#line 197 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9156, Url.Content("~/lib/sb-admin-2/vendor/datatables/dataTables.bootstrap4.min.js"), 9156, 79, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <!-- Page level custom scripts -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 9301, "\"", 9366, 1);
#nullable restore
#line 200 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9307, Url.Content("~/lib/sb-admin-2/js/demo/datatables-demo.js"), 9307, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 9392, "\"", 9428, 1);
#nullable restore
#line 202 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9398, Url.Content("~/js/custom.js"), 9398, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    ");
#nullable restore
#line 204 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
Write(RenderSection("js", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 9499, "\'", 9535, 1);
#nullable restore
#line 206 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9505, Url.Content("~/js/toastr.js"), 9505, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\'text/javascript\'></script>\r\n\r\n    <input type=\"hidden\" id=\"success\"");
                BeginWriteAttribute("value", " value=\"", 9610, "\"", 9638, 1);
#nullable restore
#line 208 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9618, TempData["success"], 9618, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"info\"");
                BeginWriteAttribute("value", " value=\"", 9678, "\"", 9703, 1);
#nullable restore
#line 209 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9686, TempData["info"], 9686, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"warning\"");
                BeginWriteAttribute("value", " value=\"", 9746, "\"", 9774, 1);
#nullable restore
#line 210 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9754, TempData["warning"], 9754, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"error\"");
                BeginWriteAttribute("value", " value=\"", 9815, "\"", 9841, 1);
#nullable restore
#line 211 "D:\C#\BanVeXeKhach\BanVeXeKhach\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 9823, TempData["error"], 9823, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

    <script>
        $(function () {
            if ($('#success').val()) {
                displayMessage($('#success').val(), 'success');
            }
            if ($('#info').val()) {
                displayMessage($('#info').val(), 'info');
            }
            if ($('#warning').val()) {
                displayMessage($('#warning').val(), 'warning');
            }
            if ($('#error').val()) {
                displayMessage($('#error').val(), 'error');
            }
        });
        var displayMessage = function (message, type) {
            toastr.options = {
                ""positionClass"": ""toast-top-right"",
                ""showDuration"": ""300"",
                ""hideDuration"": ""1000"",
                ""timeOut"": ""3000"",
                ""extendedTimeOut"": ""1000"",
                ""showEasing"": ""swing"",
                ""hideEasing"": ""linear"",
                ""showMethod"": ""fadeIn"",
                ""hideMethod"": ""fadeOut""
            };
            toastr");
                WriteLiteral("[type](message);\r\n        };\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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