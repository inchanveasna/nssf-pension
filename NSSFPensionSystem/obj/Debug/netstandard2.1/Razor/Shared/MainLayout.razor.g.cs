#pragma checksum "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ae88ca1dee9e5896b1d52ac55afe4f5f4e9634"
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
#line 4 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header-container fixed-top");
            __builder.AddMarkupContent(2, "\r\n            ");
            __builder.OpenElement(3, "header");
            __builder.AddAttribute(4, "class", "header navbar navbar-expand-sm");
            __builder.AddMarkupContent(5, "\r\n\r\n                ");
            __builder.AddMarkupContent(6, @"<ul class=""navbar-item theme-brand flex-row  text-center"">
                    <li class=""nav-item theme-logo"">
                        <a href=""index.html"">
                            <img src=""template/assets/img/logo.svg"" class=""navbar-logo"" alt=""logo"">
                        </a>
                    </li>
                    <li class=""nav-item theme-text"">
                        <a href class=""nav-link""> CORK </a>
                    </li>
                </ul>


                ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "display:flex; flex-direction: row; justify-content: center; align-items: flex-end; color: white;");
            __builder.AddAttribute(9, "class", "ml-md-auto");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "navbar-item flex-row ml-md-auto");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.AddMarkupContent(14, "<li class=\"nav-item dropdown notification-dropdown\">\r\n                            <a href=\"javascript:void(0);\" class=\"nav-link dropdown-toggle\" id=\"notificationDropdown\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-bell\"><path d=\"M18 8A6 6 0 0 0 6 8c0 7-3 9-3 9h18s-3-2-3-9\"></path><path d=\"M13.73 21a2 2 0 0 1-3.46 0\"></path></svg><span class=\"badge badge-success\"></span>\r\n                            </a>\r\n                            <div class=\"dropdown-menu position-absolute\" aria-labelledby=\"notificationDropdown\">\r\n                                <div class=\"notification-scroll\">\r\n\r\n                                    <div class=\"dropdown-item\">\r\n                                        <div class=\"media\">\r\n                                            <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-heart\"><path d=\"M20.84 4.61a5.5 5.5 0 0 0-7.78 0L12 5.67l-1.06-1.06a5.5 5.5 0 0 0-7.78 7.78l1.06 1.06L12 21.23l7.78-7.78 1.06-1.06a5.5 5.5 0 0 0 0-7.78z\"></path></svg>\r\n                                            <div class=\"media-body\">\r\n                                                <div class=\"notification-para\"><span class=\"user-name\">Shaun Park</span> likes your photo.</div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                    <div class=\"dropdown-item\">\r\n                                        <div class=\"media\">\r\n                                            <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-share-2\"><circle cx=\"18\" cy=\"5\" r=\"3\"></circle><circle cx=\"6\" cy=\"12\" r=\"3\"></circle><circle cx=\"18\" cy=\"19\" r=\"3\"></circle><line x1=\"8.59\" y1=\"13.51\" x2=\"15.42\" y2=\"17.49\"></line><line x1=\"15.41\" y1=\"6.51\" x2=\"8.59\" y2=\"10.49\"></line></svg>\r\n                                            <div class=\"media-body\">\r\n                                                <div class=\"notification-para\"><span class=\"user-name\">Kelly Young</span> shared your post</div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                    <div class=\"dropdown-item\">\r\n                                        <div class=\"media\">\r\n                                            <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-tag\"><path d=\"M20.59 13.41l-7.17 7.17a2 2 0 0 1-2.83 0L2 12V2h10l8.59 8.59a2 2 0 0 1 0 2.82z\"></path><line x1=\"7\" y1=\"7\" x2=\"7\" y2=\"7\"></line></svg>\r\n                                            <div class=\"media-body\">\r\n                                                <div class=\"notification-para\"><span class=\"user-name\">Kelly Young</span> mentioned you in comment.</div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </li>\r\n\r\n                        ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "nav-item dropdown user-profile-dropdown");
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.AddMarkupContent(18, @"<a href=""javascript:void(0);"" class=""nav-link dropdown-toggle user"" id=""userProfileDropdown"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                                <svg viewBox=""0 0 24 24"" width=""24"" height=""24"" stroke=""currentColor"" stroke-width=""2"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""css-i6dzq1""><path d=""M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2""></path><circle cx=""12"" cy=""7"" r=""4""></circle></svg>
                            </a>
                            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "dropdown-menu position-absolute");
            __builder.AddAttribute(21, "aria-labelledby", "userProfileDropdown");
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", true);
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n\r\n                                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "dropdown-item");
            __builder.AddMarkupContent(28, "\r\n                                        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "");
            __builder.AddAttribute(31, "href", "");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
                                                                      BeginSignOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                                            ");
            __builder.AddMarkupContent(34, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-log-out"">
                                                <path d=""M9 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h4""></path>
                                                <polyline points=""16 17 21 12 16 7""></polyline>
                                                <line x1=""21"" y1=""12"" x2=""9"" y2=""12""></line>
                                            </svg> ចាកចេញ
                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        \r\n\r\n        ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.NavMenu>(44);
            __builder.AddAttribute(45, "breadcrumbs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<NSSFPensionSystem.Models.BreadcrumbModel>>(
#nullable restore
#line 113 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
                               breadcrumbLinks

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n\r\n\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "main-container");
            __builder.AddAttribute(49, "id", "container");
            __builder.AddMarkupContent(50, "\r\n            <div class=\"overlay\"></div>\r\n            <div class=\"search-overlay\"></div>\r\n            ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.SidebarMenu>(51);
            __builder.AddAttribute(52, "menus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<NSSFPensionSystem.Models.MenuModel>>(
#nullable restore
#line 121 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
                                 menus

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "id", "content");
            __builder.AddAttribute(56, "class", "main-content");
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.AddContent(58, 
#nullable restore
#line 123 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\MainLayout.razor"
      

    private List<BreadcrumbModel> breadcrumbLinks = new List<BreadcrumbModel>();
    private List<MenuModel> menus = new List<MenuModel>();
    //private string currentUrl;



    protected override async Task OnInitializedAsync()
    {
        await runtime.InvokeAsync<object>("AppInit");
        menus = await userService.GetMenus(2044);



    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await runtime.InvokeAsync<object>("AppInit");

        }

        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;



        if (user.Identity.IsAuthenticated)
        {
            UserModel userLogin = new UserModel()
            {
                Name = user.Claims.Where(w => w.Type == "name").FirstOrDefault()?.Value,
                EmpId = Convert.ToInt32(user.Claims.Where(w => w.Type == "emp_id").FirstOrDefault()?.Value),
                Username = user.Claims.Where(w => w.Type == "preferred_username").FirstOrDefault()?.Value,
                Picture = user.Claims.Where(w => w.Type == "picture").FirstOrDefault()?.Value,
                AccessToken = user.Claims.Where(w => w.Type == "access_token").FirstOrDefault()?.Value
            };

            await localStorage.SetItemAsync<UserModel>("user", userLogin);
        }
    }


    


    protected override void OnParametersSet()
    {

        //currentUrl = NavigationManager.Uri;
        //var myUrl = currentUrl.Replace(NavigationManager.BaseUri, "");
        //breadcrumbLinks.Clear();
        //breadcrumbLinks.Add(new BreadcrumbModel
        //{
        //    Address = NavigationManager.BaseUri,
        //    IsActive = NavigationManager.Uri == NavigationManager.BaseUri,
        //    OrderIndex = 1,
        //    Title = "ទំព័រដើម"
        //});
        //var path = myUrl.Split('/');
        //var count = 1;

        //foreach (var link in path)
        //{
        //    if (link == "") continue;
        //    count++;
        //    var lastLink = breadcrumbLinks.Last();
        //    breadcrumbLinks.Add(new BreadcrumbModel
        //    {
        //        Address = $"{lastLink.Address}{link}",
        //        IsActive = link == path.Last(),
        //        OrderIndex = count,
        //        Title = menus.FirstOrDefault().subMenu.Where(w => w.menu_link == link).Select(s => s.menu_name).FirstOrDefault()
        //    });
        //}

        base.OnParametersSet();
    }


    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        NavigationManager.NavigateTo("authentication/logout");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
