#pragma checksum "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e360dc77e77ec4880d02eca5150afc3ce318bd46"
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
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " fade" + " " + (
#nullable restore
#line 1 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                        modalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "data-backdrop", "static");
            __builder.AddAttribute(3, "data-keyboard", "false");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "aria-labelledby", "staticBackdropLabel");
            __builder.AddAttribute(6, "aria-hidden", "true");
            __builder.AddAttribute(7, "style", "display:" + (
#nullable restore
#line 1 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                                                                                                                                                                        modalDisplay

#line default
#line hidden
#nullable disable
            ) + ";" + " overflow-y:" + " auto;");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog modal-dialog-centered modal-lg");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-header");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "modal-title");
            __builder.AddAttribute(20, "id", "exampleModalLabel");
            __builder.AddContent(21, 
#nullable restore
#line 5 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "close");
            __builder.AddAttribute(26, "data-dismiss", "modal");
            __builder.AddAttribute(27, "aria-label", "Close");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                                                                                                      Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-body");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddContent(35, 
#nullable restore
#line 9 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-footer");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.AddContent(41, 
#nullable restore
#line 12 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
                 Footer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n");
#nullable restore
#line 19 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
 if (showBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 22 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Modal.razor"
       
    [Parameter]
    public RenderFragment Title { get; set; }

    [Parameter]
    public RenderFragment Body { get; set; }

    [Parameter]
    public RenderFragment Footer { get; set; }

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