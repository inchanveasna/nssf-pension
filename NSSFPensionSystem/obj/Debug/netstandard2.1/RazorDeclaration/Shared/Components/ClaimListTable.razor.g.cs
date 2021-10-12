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
    public partial class ClaimListTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\INCHANVEASNA\Desktop\NSSFPensionSystem\NSSFPensionSystem\Shared\Components\ClaimListTable.razor"
                   

                [Parameter]
                public List<PensionTypeModel> PensionTypes { get; set; }

                [Parameter]
                public List<ClaimStatusModel> ClaimStatuses { get; set; }


                [Parameter]
                public List<String> TableHeader { get; set; }

                [Parameter]
                public List<ClaimModel> ClaimList { get; set; }

                [Parameter]
                public int StatusId { get; set; }


                [Parameter]
                public EventCallback<int> OnEdit { get; set; }

                public void OnEditClick(int index)
                {
                    OnEdit.InvokeAsync(index);
                }

                public string GetColorForClaimStatus(int id)
                {
                    string result = "var(--info)";

                    switch (id)
                    {
                        case 1: result = "var(--info)"; break;
                        case 2: result = "var(--warning)"; break;
                        case 3:
                        case 5:
                        case 7:
                        case 9:
                            result = "var(--success)"; break;
                        case 4:
                        case 6:
                        case 8:
                        case 10:
                            result = "var(--danger)"; break;
                    }

                    return result;
                }
            

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
