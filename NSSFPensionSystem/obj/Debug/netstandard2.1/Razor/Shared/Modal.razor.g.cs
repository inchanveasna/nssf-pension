#pragma checksum "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "254d8dae501a0a0b5f336749e9db192d03e53ed9"
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
#line 1 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Blazored.LocalStorage;

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
#line 1 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
          Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "modal" + " fade" + " " + (
#nullable restore
#line 1 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
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
#line 1 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                                                                                                                                                                                 modalDisplay

#line default
#line hidden
#nullable disable
            ) + ";" + " overflow-y:" + " auto;");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-dialog" + " " + (
#nullable restore
#line 2 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                               CenterScreen ? "modal-dialog-centered" : ""

#line default
#line hidden
#nullable disable
            ) + " modal-" + (
#nullable restore
#line 2 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                                                                                   Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-content");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-header");
            __builder.AddAttribute(18, "style", "padding: 10px 16px !important; align-content:center !important");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "h5");
            __builder.AddAttribute(21, "class", "modal-title");
            __builder.AddContent(22, 
#nullable restore
#line 5 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-body");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddContent(28, 
#nullable restore
#line 9 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "modal-footer");
            __builder.AddAttribute(33, "style", "padding: 4px 8px !important;");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddContent(35, 
#nullable restore
#line 12 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                 Footer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n\r\n");
#nullable restore
#line 19 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
 if (showBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 22 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
       
    [Parameter]
    public string Id { get; set; } = "id";

    [Parameter]
    public RenderFragment Title { get; set; }

    [Parameter]
    public RenderFragment Body { get; set; }

    [Parameter]
    public RenderFragment Footer { get; set; }

    [Parameter]
    public string Size { get; set; } = "lg";

    [Parameter]
    public bool CenterScreen { get; set; } = true;


    private string modalDisplay = "none;";
    private string modalClass = "";
    private bool showBackdrop = false;

    public void Open()
    {
        modalDisplay = "block;";
        modalClass = "show";
        showBackdrop = true;
    }

    public void Close()
    {
        modalDisplay = "none";
        modalClass = "";
        showBackdrop = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
