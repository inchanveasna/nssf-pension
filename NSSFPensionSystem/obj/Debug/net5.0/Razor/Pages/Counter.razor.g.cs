#pragma checksum "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01c8ed61bd9efb587081062c9d06a4d6f0453d3"
// <auto-generated/>
#pragma warning disable 1591
namespace NSSFPensionSystem.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Counter.razor"
                 com

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h1>Counter</h1>\r\n\r\n    ");
                __builder2.OpenElement(4, "p");
                __builder2.AddContent(5, "Current count: ");
                __builder2.AddContent(6, 
#nullable restore
#line 5 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Counter.razor"
                       currentCount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n   \r\n    \r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    \r\n\r\n    ");
                __builder2.OpenElement(10, "button");
                __builder2.AddAttribute(11, "class", "btn btn-primary");
                __builder2.AddAttribute(12, "type", "submit");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Counter.razor"
                                                            IncrementCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(14, "Click me");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Counter.razor"
       
    private int currentCount = 0;

    protected CommuneModel com { get; set; } = new CommuneModel();

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591