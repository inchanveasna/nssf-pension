// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/_Imports.razor"
using NSSFPensionSystem.Setting;

#line default
#line hidden
#nullable disable
    public partial class MessageBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/Users/chanveasnain/Desktop/NSSFPensionSystem/nssf-pension/NSSFPensionSystem/Shared/MessageBox.razor"
       
  
    [Parameter]
    public string Id { get; set; } = "id";

    [Parameter]
    public MessageBoxTypes Type { get; set; } = MessageBoxTypes.Info;

    //[Parameter]
    //public RenderFragment Message { get; set; }


    [Parameter]
    public EventCallback<bool> OnConfirmation{ get; set; }

    private string modalDisplay = "none;";
    private string modalClass = "";
    private bool showBackdrop = false;

    private string Message = "";

    public async void Open(MessageBoxTypes type, string message)
    {
        await Confirmation(false);
        Type = type;
        Message = message;
        StateHasChanged();

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

    
    public async Task Confirmation(bool value)
    {
        Close();
        await OnConfirmation.InvokeAsync(value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
