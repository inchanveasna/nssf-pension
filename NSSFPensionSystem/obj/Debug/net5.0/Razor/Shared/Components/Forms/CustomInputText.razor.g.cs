#pragma checksum "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9cc36497c35240229c37b5f848a276d4d98d053"
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
#nullable restore
#line 2 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class CustomInputText : Microsoft.AspNetCore.Components.Forms.InputText
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group" + " col-md-" + (
#nullable restore
#line 6 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                               ColMd

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "label");
            __builder.AddAttribute(3, "for", 
#nullable restore
#line 7 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                 id.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 7 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                                         IsRequired

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, 
#nullable restore
#line 7 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                                                       LabelText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "id", 
#nullable restore
#line 8 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                id.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "type", 
#nullable restore
#line 9 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                  Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "form-control" + " " + (
#nullable restore
#line 10 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                                CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMultipleAttributes(11, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 11 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                         AdditionalAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "placeholder", 
#nullable restore
#line 12 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                         PlaceHolder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "disabled", 
#nullable restore
#line 14 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                      Disable

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "readonly", 
#nullable restore
#line 15 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                      ReadlOnly

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 16 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                       ()=> ShowError=true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                   CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 17 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
     if (!string.IsNullOrWhiteSpace(Description))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "small");
            __builder.AddAttribute(19, "class", "form-text text-muted");
            __builder.AddContent(20, 
#nullable restore
#line 19 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                                             Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
     if (ShowError)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
         foreach (var msg in EditContext.GetValidationMessages(FieldIdentifier))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "validation-message");
            __builder.AddContent(23, 
#nullable restore
#line 25 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
                                             msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Shared\Components\Forms\CustomInputText.razor"
       
    Guid id = Guid.NewGuid();
    [Parameter] public bool ShowError { get; set; } = false;
    [Parameter] public string LabelText { get; set; } = "";
    [Parameter] public string PlaceHolder { get; set; } = "";
    [Parameter] public string Type { get; set; } = "text";
    [Parameter] public string Description { get; set; } = "";
    [Parameter] public bool Disable { get; set; } = false;
    [Parameter] public bool ReadlOnly { get; set; } = false;
    [Parameter] public bool IsRequired { get; set; } = false;
    [Parameter] public bool ShowRequired { get; set; } = false;
    [Parameter] public int ColMd { get; set; } = 6;


    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        return base.OnAfterRenderAsync(firstRender);
    }

    protected override Task OnParametersSetAsync()
    {
        try
        {


            var displayAttribute = this.FieldIdentifier.Model.GetType()
                .GetProperty(this.FieldIdentifier.FieldName)
                .GetCustomAttributes<DisplayAttribute>();

            if (displayAttribute != null)
            {
                var displayName = displayAttribute.FirstOrDefault().Name;
                if (!String.IsNullOrEmpty(displayName) && string.IsNullOrEmpty(LabelText))
                {
                    LabelText = displayName;
                }

                var placeholder = displayAttribute.FirstOrDefault().Prompt;
                if (!String.IsNullOrEmpty(placeholder) && string.IsNullOrEmpty(PlaceHolder))
                {
                    PlaceHolder = placeholder;
                }

                var desc = displayAttribute.FirstOrDefault().Description;
                if (!String.IsNullOrEmpty(desc) && string.IsNullOrEmpty(Description))
                {
                    Description = desc;
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
        return base.OnParametersSetAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
