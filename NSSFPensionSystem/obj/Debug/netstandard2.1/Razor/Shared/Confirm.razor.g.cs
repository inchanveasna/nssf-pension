#pragma checksum "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Confirm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbc054f4b0f14d948182f8d713f0da75ae58b6fa"
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
    public partial class Confirm : ConfirmBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Confirm.razor"
 if (ShowConfirmation)
{



#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, @"<div class=""modal fade"" id=""confirmmodal"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">អ្នកពាក់ព័ន្ធសោធនិក</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">x</button>
                </div>
                <div class=""modal-body"">

                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-danger"" data-dismiss=""modal""><i class=""flaticon-cancel-12""></i>បោះបង់</button>
                    <button type=""button"" class=""btn btn-primary"">យល់ព្រម</button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 25 "E:\Development\NSSFPensionSystem\NSSFPensionSystem\Shared\Confirm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
