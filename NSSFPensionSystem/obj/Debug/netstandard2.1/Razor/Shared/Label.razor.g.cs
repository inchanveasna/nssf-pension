#pragma checksum "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/Shared/Label.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d56b6052361e8871c69990393fed197267e3d98d"
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
#line 1 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class Label : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "label");
            __builder.AddAttribute(1, "for", 
#nullable restore
#line 3 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/Shared/Label.razor"
             For

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, 
#nullable restore
#line 3 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/Shared/Label.razor"
                   Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "style", "color: red !important; font-weight: 400 !important;");
            __builder.AddContent(5, 
#nullable restore
#line 3 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/Shared/Label.razor"
                                                                                                    IsRequire ? " *" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/Shared/Label.razor"
       

    [Parameter]
    public bool IsRequire { get; set; } = false;

    [Parameter]
    public string Text { get; set; } = "";

    [Parameter]
    public string For { get; set; } = "";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
