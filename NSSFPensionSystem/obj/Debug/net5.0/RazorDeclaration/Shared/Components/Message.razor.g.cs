// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Message : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Message.razor"
       
    private MessageTypes Type { get; set; } = MessageTypes.INFO;
    private string Title { get; set; } = "";
    private string Msg { get; set; } = "";

    private TaskCompletionSource<bool> cancel = new TaskCompletionSource<bool>();

    private string modalDisplay = "none;";
    private string modalClass = "";
    private bool showBackdrop = false;

    public Task<bool> IsCancel => cancel.Task;

    public async Task Show(MessageTypes type, string message)
    {
        await Task.Factory.StartNew(() =>
        {
            cancel = new TaskCompletionSource<bool>();

            this.Type = type;
            this.Title = this.GetTitle(type);
            this.Msg = message;

            modalDisplay = "block;";
            modalClass = "show";
            showBackdrop = true;
        });
        StateHasChanged();
    }


    public async Task Show(MessageTypes type, MessageText text)
    {
        await Show(type, GetMessageText(text));
    }


    private async Task Cancel()
    {
        cancel.TrySetResult(true);
        await Close();
    }

    private async Task Confirmed()
    {
        cancel.TrySetResult(false);
        await Close();
    }


    private async Task Close()
    {
        await Task.Factory.StartNew(() =>
        {
            modalDisplay = "none";
            modalClass = "";
            showBackdrop = false;
        });
        StateHasChanged();
    }


    private string GetTitle(MessageTypes type)
    {
        string title = "";
        switch (type)
        {
            case MessageTypes.CONFIRM:
                title = "សារបញ្ជាក់"; break;
            case MessageTypes.ERROR:
                title = "សារកំហុស"; break;
            case MessageTypes.INFO:
                title = "សារជូនដំណឹង"; break;
            case MessageTypes.WARNING:
                title = "សារជូនដំណឹង"; break;
        }

        return title;
    }

    private string GetMessageText(MessageText type)
    {
        string text = "";
        switch (type)
        {
            case MessageText.REMOVE_CONFIRMATION:
                text = "តើអ្នកពិតជាចង់ដកចេញមែនទេ?"; break;
            case MessageText.SUCCESS:
                text = "ប្រតិបត្តិការទទួលបានជោគជ័យ!"; break;
            case MessageText.UNSUCCESS:
                text = "ប្រតិបត្តិការមិនទទួលបានជោគជ័យ!"; break;
            case MessageText.NO_DATA:
                text = "ទិន្នន័យមិនមាននៅក្នុងប្រព័ន្ធ!"; break;
        }

        return text;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591