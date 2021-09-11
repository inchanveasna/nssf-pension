#pragma checksum "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06346b74c113cf03827c3c29ec158ead0866dd21"
// <auto-generated/>
#pragma warning disable 1591
namespace NSSFPensionSystem.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Controllers.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"header-container fixed-top\">\r\n    <header class=\"header navbar navbar-expand-sm\">\r\n\r\n        <ul class=\"navbar-item theme-brand flex-row  text-center\">\r\n            <li class=\"nav-item theme-logo\">\r\n                <a href=\"index.html\">\r\n                    <img src=\"template/assets/img/logo.svg\" class=\"navbar-logo\" alt=\"logo\">\r\n                </a>\r\n            </li>\r\n            <li class=\"nav-item theme-text\">\r\n                <a href=\"index.html\" class=\"nav-link\"> CORK </a>\r\n            </li>\r\n        </ul>\r\n\r\n        <ul class=\"navbar-item flex-row ml-md-0 ml-auto\">\r\n            <li class=\"nav-item align-self-center search-animated\">\r\n                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-search toggle-search\"><circle cx=\"11\" cy=\"11\" r=\"8\"></circle><line x1=\"21\" y1=\"21\" x2=\"16.65\" y2=\"16.65\"></line></svg>\r\n                <form class=\"form-inline search-full form-inline search\" role=\"search\">\r\n                    <div class=\"search-bar\">\r\n                        <input type=\"text\" class=\"form-control search-form-control  ml-lg-auto\" placeholder=\"Search...\">\r\n                    </div>\r\n                </form>\r\n            </li>\r\n        </ul>\r\n\r\n        <ul class=\"navbar-item flex-row ml-md-auto\">\r\n\r\n            <li class=\"nav-item dropdown language-dropdown\">\r\n                <a href=\"javascript:void(0);\" class=\"nav-link dropdown-toggle\" id=\"language-dropdown\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                    <img src=\"template/assets/img/ca.png\" class=\"flag-width\" alt=\"flag\">\r\n                </a>\r\n                <div class=\"dropdown-menu position-absolute\" aria-labelledby=\"language-dropdown\">\r\n                    <a class=\"dropdown-item d-flex\" href=\"javascript:void(0);\"><img src=\"template/assets/img/de.png\" class=\"flag-width\" alt=\"flag\"> <span class=\"align-self-center\">&nbsp;German</span></a>\r\n                    <a class=\"dropdown-item d-flex\" href=\"javascript:void(0);\"><img src=\"template/assets/img/jp.png\" class=\"flag-width\" alt=\"flag\"> <span class=\"align-self-center\">&nbsp;Japanese</span></a>\r\n                    <a class=\"dropdown-item d-flex\" href=\"javascript:void(0);\"><img src=\"template/assets/img/fr.png\" class=\"flag-width\" alt=\"flag\"> <span class=\"align-self-center\">&nbsp;French</span></a>\r\n                    <a class=\"dropdown-item d-flex\" href=\"javascript:void(0);\"><img src=\"template/assets/img/ca.png\" class=\"flag-width\" alt=\"flag\"> <span class=\"align-self-center\">&nbsp;English</span></a>\r\n                </div>\r\n            </li>\r\n\r\n            <li class=\"nav-item dropdown message-dropdown\">\r\n                <a href=\"javascript:void(0);\" class=\"nav-link dropdown-toggle\" id=\"messageDropdown\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                    <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-mail\"><path d=\"M4 4h16c1.1 0 2 .9 2 2v12c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2z\"></path><polyline points=\"22,6 12,13 2,6\"></polyline></svg>\r\n                </a>\r\n                <div class=\"dropdown-menu p-0 position-absolute\" aria-labelledby=\"messageDropdown\">\r\n                    <div class>\r\n                        <a class=\"dropdown-item\">\r\n                            <div class>\r\n\r\n                                <div class=\"media\">\r\n                                    <div class=\"user-img\">\r\n                                        <img class=\"usr-img rounded-circle\" src=\"template/assets/img/profile-11.jpg\" alt=\"profile\">\r\n                                    </div>\r\n                                    <div class=\"media-body\">\r\n                                        <div class>\r\n                                            <h5 class=\"usr-name\">Kara Young</h5>\r\n                                            <p class=\"msg-title\">ACCOUNT UPDATE</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </a>\r\n                        <a class=\"dropdown-item\">\r\n                            <div class>\r\n\r\n                                <div class=\"media\">\r\n                                    <div class=\"user-img\">\r\n                                        <img class=\"usr-img rounded-circle\" src=\"template/assets/img/profile-16.jpg\" alt=\"profile\">\r\n                                    </div>\r\n                                    <div class=\"media-body\">\r\n                                        <div class>\r\n                                            <h5 class=\"usr-name\">Daisy Anderson</h5>\r\n                                            <p class=\"msg-title\">ACCOUNT UPDATE</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </a>\r\n                        <a class=\"dropdown-item\">\r\n                            <div class>\r\n\r\n                                <div class=\"media\">\r\n                                    <div class=\"user-img\">\r\n                                        <img class=\"usr-img rounded-circle\" src=\"template/assets/img/profile-34.jpg\" alt=\"profile\">\r\n                                    </div>\r\n                                    <div class=\"media-body\">\r\n                                        <div class>\r\n                                            <h5 class=\"usr-name\">Oscar Garner</h5>\r\n                                            <p class=\"msg-title\">ACCOUNT UPDATE</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n\r\n            <li class=\"nav-item dropdown notification-dropdown\">\r\n                <a href=\"javascript:void(0);\" class=\"nav-link dropdown-toggle\" id=\"notificationDropdown\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                    <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-bell\"><path d=\"M18 8A6 6 0 0 0 6 8c0 7-3 9-3 9h18s-3-2-3-9\"></path><path d=\"M13.73 21a2 2 0 0 1-3.46 0\"></path></svg><span class=\"badge badge-success\"></span>\r\n                </a>\r\n                <div class=\"dropdown-menu position-absolute\" aria-labelledby=\"notificationDropdown\">\r\n                    <div class=\"notification-scroll\">\r\n\r\n                        <div class=\"dropdown-item\">\r\n                            <div class=\"media\">\r\n                                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-heart\"><path d=\"M20.84 4.61a5.5 5.5 0 0 0-7.78 0L12 5.67l-1.06-1.06a5.5 5.5 0 0 0-7.78 7.78l1.06 1.06L12 21.23l7.78-7.78 1.06-1.06a5.5 5.5 0 0 0 0-7.78z\"></path></svg>\r\n                                <div class=\"media-body\">\r\n                                    <div class=\"notification-para\"><span class=\"user-name\">Shaun Park</span> likes your photo.</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"dropdown-item\">\r\n                            <div class=\"media\">\r\n                                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-share-2\"><circle cx=\"18\" cy=\"5\" r=\"3\"></circle><circle cx=\"6\" cy=\"12\" r=\"3\"></circle><circle cx=\"18\" cy=\"19\" r=\"3\"></circle><line x1=\"8.59\" y1=\"13.51\" x2=\"15.42\" y2=\"17.49\"></line><line x1=\"15.41\" y1=\"6.51\" x2=\"8.59\" y2=\"10.49\"></line></svg>\r\n                                <div class=\"media-body\">\r\n                                    <div class=\"notification-para\"><span class=\"user-name\">Kelly Young</span> shared your post</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"dropdown-item\">\r\n                            <div class=\"media\">\r\n                                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-tag\"><path d=\"M20.59 13.41l-7.17 7.17a2 2 0 0 1-2.83 0L2 12V2h10l8.59 8.59a2 2 0 0 1 0 2.82z\"></path><line x1=\"7\" y1=\"7\" x2=\"7\" y2=\"7\"></line></svg>\r\n                                <div class=\"media-body\">\r\n                                    <div class=\"notification-para\"><span class=\"user-name\">Kelly Young</span> mentioned you in comment.</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n\r\n            <li class=\"nav-item dropdown user-profile-dropdown\">\r\n                <a href=\"javascript:void(0);\" class=\"nav-link dropdown-toggle user\" id=\"userProfileDropdown\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"true\">\r\n                    <img src=\"template/assets/img/profile-16.jpg\" alt=\"avatar\">\r\n                </a>\r\n                <div class=\"dropdown-menu position-absolute\" aria-labelledby=\"userProfileDropdown\">\r\n                    <div class>\r\n                        <div class=\"dropdown-item\">\r\n                            <a class href=\"user_profile.html\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-user\"><path d=\"M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2\"></path><circle cx=\"12\" cy=\"7\" r=\"4\"></circle></svg> My Profile</a>\r\n                        </div>\r\n                        <div class=\"dropdown-item\">\r\n                            <a class href=\"apps_mailbox.html\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-inbox\"><polyline points=\"22 12 16 12 14 15 10 15 8 12 2 12\"></polyline><path d=\"M5.45 5.11L2 12v6a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2v-6l-3.45-6.89A2 2 0 0 0 16.76 4H7.24a2 2 0 0 0-1.79 1.11z\"></path></svg> Inbox</a>\r\n                        </div>\r\n                        <div class=\"dropdown-item\">\r\n                            <a class href=\"auth_lockscreen.html\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-lock\"><rect x=\"3\" y=\"11\" width=\"18\" height=\"11\" rx=\"2\" ry=\"2\"></rect><path d=\"M7 11V7a5 5 0 0 1 10 0v4\"></path></svg> Lock Screen</a>\r\n                        </div>\r\n                        <div class=\"dropdown-item\">\r\n                            <a class href=\"auth_login.html\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-log-out\"><path d=\"M9 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h4\"></path><polyline points=\"16 17 21 12 16 7\"></polyline><line x1=\"21\" y1=\"12\" x2=\"9\" y2=\"12\"></line></svg> Sign Out</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n\r\n        </ul>\r\n    </header>\r\n</div>\r\n\r\n\r\n");
            __builder.OpenComponent<NSSFPensionSystem.Shared.NavMenu>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main-container");
            __builder.AddAttribute(5, "id", "container");
            __builder.AddMarkupContent(6, "\r\n\r\n    <div class=\"overlay\"></div>\r\n    <div class=\"search-overlay\"></div>\r\n\r\n    ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.SidebarMenu>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "content");
            __builder.AddAttribute(11, "class", "main-content");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "container-fluid");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddContent(16, 
#nullable restore
#line 183 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        \r\n        ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Footer>(19);
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    \r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 196 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
       
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        await runtime.InvokeAsync<object>("AppInit");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
    }
}
#pragma warning restore 1591
