#pragma checksum "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e4de3e0c846b17a502c362861876e810a782f45"
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
#line 1 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor.AdminLte.NavBar>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazor.AdminLte.NavBarLeft>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(4, 
#nullable restore
#line 8 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
         navBarLeftInjectableMenu.content

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
                __builder2.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
#nullable restore
#line 13 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
              
                if (context.User.Identity.IsAuthenticated)
                {
                    var claim = context.User.Claims.ToList();

                    UserModel userLogin = new UserModel()
                    {
                        Name = claim.Where(w => w.Type == "name").FirstOrDefault()?.Value,
                        EmpId = Convert.ToInt32(claim.Where(w => w.Type == "emp_id").FirstOrDefault()?.Value),
                        Username = claim.Where(w => w.Type == "preferred_username").FirstOrDefault()?.Value,
                        Picture = claim.Where(w => w.Type == "picture").FirstOrDefault()?.Value,
                        AccessToken = claim.Where(w => w.Type == "access_token").FirstOrDefault()?.Value
                    };

                    this.LoginComplete(userLogin);

                }
            

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(8, "ul");
                    __builder3.AddAttribute(9, "class", "navbar-nav ml-auto");
                    __builder3.AddAttribute(10, "b-hsldet3n9d");
                    __builder3.OpenElement(11, "li");
                    __builder3.AddAttribute(12, "class", "nav-item dropdown");
                    __builder3.AddAttribute(13, "b-hsldet3n9d");
                    __builder3.OpenElement(14, "a");
                    __builder3.AddAttribute(15, "class", "nav-link");
                    __builder3.AddAttribute(16, "data-toggle", "dropdown");
                    __builder3.AddAttribute(17, "href", "#");
                    __builder3.AddAttribute(18, "b-hsldet3n9d");
                    __builder3.AddMarkupContent(19, "<i class=\"fa-solid fa-circle-user\" b-hsldet3n9d></i>\r\n                        ");
                    __builder3.AddContent(20, 
#nullable restore
#line 35 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                          UserService.Current.EmpNameFirstKhmer + " " + UserService.Current.EmpNameLastKhmer

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\r\n                    ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "dropdown-menu dropdown-menu-lg dropdown-menu-right");
                    __builder3.AddAttribute(24, "b-hsldet3n9d");
                    __builder3.AddMarkupContent(25, "<span class=\"dropdown-item dropdown-header\" b-hsldet3n9d>អ្នកប្រើប្រាស់</span>\r\n                        <div class=\"dropdown-divider\" b-hsldet3n9d></div>\r\n                        ");
                    __builder3.AddMarkupContent(26, "<a href=\"#\" class=\"dropdown-item\" b-hsldet3n9d><i class=\"fa-solid fa-key\" b-hsldet3n9d></i> ប្ដូរលេខសំងាត់\r\n                        </a>\r\n                        <div class=\"dropdown-divider\" b-hsldet3n9d></div>\r\n                        ");
                    __builder3.OpenElement(27, "a");
                    __builder3.AddAttribute(28, "href", "#");
                    __builder3.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                              BeginSignOut

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "class", "dropdown-item dropdown-logout text-danger");
                    __builder3.AddAttribute(31, "b-hsldet3n9d");
                    __builder3.AddMarkupContent(32, "<i class=\"fa-solid fa-arrow-right-from-bracket\" b-hsldet3n9d></i> ចាកចេញ\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(34, "<li class=\"nav-item\" b-hsldet3n9d><a class=\"nav-link\" data-widget=\"fullscreen\" href=\"#\" role=\"button\" b-hsldet3n9d><i class=\"fas fa-expand-arrows-alt\" b-hsldet3n9d></i></a></li>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.AddAttribute(35, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Blazor.AdminLte.NavBarRight>(36);
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(38, "<button class=\"btn btn-default btn-sm\" b-hsldet3n9d><i class=\"fa-solid fa-right-from-bracket\" b-hsldet3n9d></i> ចូលប្រើប្រាស់\r\n                </button>");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.OpenComponent<NSSFPensionSystem.Shared.RedirectToLogin>(40);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenComponent<Blazor.AdminLte.SideBarContainer>(42);
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazor.AdminLte.BrandLogo>(44);
                __builder2.AddAttribute(45, "Link", "#");
                __builder2.AddAttribute(46, "Logo", "img/logonssf.png");
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(48, "ប្រព័ន្ធសោធន");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(50);
                __builder2.AddAttribute(51, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Blazor.AdminLte.SideBar>(52);
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazor.AdminLte.SideBarMenu>(54);
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 74 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                     if (UserService.Current.Menus != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                         foreach (var menu in UserService.Current.Menus)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                             if (menu.subMenu.Count == 0)
                            {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<Blazor.AdminLte.SideBarMenuItem>(56);
                            __builder5.AddAttribute(57, "Link", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                                        menu.menu_link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(58, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                                                               menu.menu_icon

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(60, 
#nullable restore
#line 81 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                     menu.menu_name

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 83 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<Blazor.AdminLte.SideBarTreeView>(61);
                            __builder5.AddAttribute(62, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                                        menu.menu_icon

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(63, "Title", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(64, 
#nullable restore
#line 87 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                            menu.menu_name

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.AddAttribute(65, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 90 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                         foreach (var subMenu in menu.subMenu)
                                        {

#line default
#line hidden
#nullable disable
                                __builder6.OpenComponent<Blazor.AdminLte.SideBarMenuItem>(66);
                                __builder6.AddAttribute(67, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 92 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                                                    subMenu.menu_icon

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(68, "Link", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 92 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                                                                              subMenu.menu_link

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(70, 
#nullable restore
#line 93 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                                 subMenu.menu_name

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
#nullable restore
#line 95 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                                        }

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 98 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.OpenComponent<Blazor.AdminLte.ContentWrapper>(72);
            __builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(74, 
#nullable restore
#line 107 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\MainLayout.razor"
       

    protected override void OnParametersSet()
    {
        // content = null; for refreshing custom menu injectables per page.
        // no override; reset default to show parent menu content items.
        navBarLeftInjectableMenu.SetContent(null, false);
    }

    private async void LoginComplete(UserModel user)
    {
        if (UserService.Current.EmpId == 0)
        {
            UserService.Current = await userService.Get(user.EmpId);
            StateHasChanged();
        }
    }

    private DateTime dt = DateTime.Now;



    protected override void OnAfterRender(bool isFirstRender)
    {
        layoutManager.IsFooterFixed = true;
        layoutManager.IsNavBarFixed = true;
        layoutManager.IsSideBarFixed = true;
        base.OnAfterRender(isFirstRender);
    }

    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        NavigationManager.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavBarLeftInjectableMenu navBarLeftInjectableMenu { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILayoutManager layoutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
