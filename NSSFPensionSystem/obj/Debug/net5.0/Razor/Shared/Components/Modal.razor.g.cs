#pragma checksum "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65466fd1227186292f82977b1e0f28028d0649f8"
// <auto-generated/>
#pragma warning disable 1591
namespace NSSFPensionSystem.Shared.Components
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
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 2 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
          Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "modal" + " fade" + " " + (
#nullable restore
#line 2 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                                 modalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "data-backdrop", "static");
            __builder.AddAttribute(4, "data-keyboard", "false");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "aria-labelledby", "staticBackdropLabel");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddAttribute(8, "style", "display:" + (
#nullable restore
#line 2 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                                                                                                                                                                                 modalDisplay

#line default
#line hidden
#nullable disable
            ) + ";" + " overflow-y:" + " auto;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog" + " " + (
#nullable restore
#line 3 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                               CenterScreen ? "modal-dialog-centered" : ""

#line default
#line hidden
#nullable disable
            ) + " modal-" + (
#nullable restore
#line 3 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                                                                                   Size

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddAttribute(15, "style", "padding: 10px 16px !important; align-content:center !important");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddContent(18, 
#nullable restore
#line 6 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", 
#nullable restore
#line 9 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                          WithoutBody ? "modal-no-body" : "modal-body"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, 
#nullable restore
#line 10 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-footer");
            __builder.AddAttribute(26, "style", "padding: 4px 8px !important;");
            __builder.AddContent(27, 
#nullable restore
#line 13 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
                 Footer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
 if (showBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<div class=\"modal-backdrop fade show\"></div>");
#nullable restore
#line 23 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Modal.razor"
 

    [Parameter] public string Id { get; set; } = "id";
    [Parameter] public RenderFragment Title { get; set; }
    [Parameter] public RenderFragment Body { get; set; }
    [Parameter] public RenderFragment Footer { get; set; }
    [Parameter] public string Size { get; set; } = "lg";
    [Parameter] public bool CenterScreen { get; set; } = true;
    [Parameter] public bool WithoutBody { get; set; } = false;


    private string modalDisplay = "none;";
    private string modalClass = "";
    private bool showBackdrop = false;

    public void Open()
    {
        modalDisplay = "block;";
        modalClass = "show";
        showBackdrop = true;
    }

    public async Task Show()
    {
        await Task.Factory.StartNew(() =>
        {
            modalDisplay = "block;";
            modalClass = "show";
            showBackdrop = true;
        });
        StateHasChanged();
    }




    public async Task Close()
    {
        await Task.Factory.StartNew(() =>
        {
            modalDisplay = "none";
            modalClass = "";
            showBackdrop = false;
        });
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
