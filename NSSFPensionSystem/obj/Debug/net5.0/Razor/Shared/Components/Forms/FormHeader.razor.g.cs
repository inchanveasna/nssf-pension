#pragma checksum "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\FormHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd07f72fc61297073e2f1afe27e1f1731dbce63"
// <auto-generated/>
#pragma warning disable 1591
namespace NSSFPensionSystem.Shared.Components.Forms
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
    public partial class FormHeader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content-header mx-3 pt-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row align-middle");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-sm-6");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "page-title");
            __builder.OpenElement(10, "i");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 5 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\FormHeader.razor"
                                                   Icon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 5 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\FormHeader.razor"
                                                               Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-sm-6");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Breadcrumb>(17);
            __builder.AddAttribute(18, "IsNull", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\FormHeader.razor"
                                     IsBreadcrumbItemNull

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\FormHeader.razor"
       
    [Parameter] public String Title { get; set; } = "";
    [Parameter] public String Icon { get; set; } = "";
    [Parameter] public String IsBreadcrumbItemNull { get; set; } = "";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
