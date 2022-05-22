// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NSSFPensionSystem.Pages.Claim
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
    public partial class ClaimFamilyModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Claim\ClaimFamilyModal.razor"
       

    [Inject] private IJSRuntime Runtime { get; set; }
    [Inject] private IConstantValueService ConstantValue { get; set; }



    private ClaimFamilyMemberModel Member { get; set; } = new();

    [Parameter] public List<GenderModel> Genders { get; set; }
    [Parameter] public List<NationalityModel> Nationalities { get; set; }
    [Parameter] public List<RelationshipModel> Relationships { get; set; }
    [Parameter] public List<String> TableHeaderDocument { get; set; }
    [Parameter] public List<DocumentModel> Documents { get; set; }
    [Parameter] public EventCallback<Tuple<int, ClaimFamilyMemberModel>> OnSubmit { get; set; }


    private Modal MyModal { get; set; }
    private ClaimDocumentModal DocumentModal { get; set; }
    private int Index { get; set; } = -1;
    private ClaimFamilyMemberDocumentModel MemberDoc { get; set; } = new();
    private Message MessageBox { get; set; }
    private DotNetObjectReference<ClaimFamilyModal> JsRef;



    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            JsRef = DotNetObjectReference.Create(this);
            await Runtime.InvokeAsync<object>("ClaimFamily", JsRef);
        }

        await this.OnSexChanged(Member.GenId);
        await base.OnAfterRenderAsync(firstRender);
    }


    public async Task Show(int index)
    {
        this.Index = index;

        if (Index == -1) Member = new ClaimFamilyMemberModel();
        await MyModal.Show();
    }

   

    private async Task Submit()
    {
        Member.Nationality = Nationalities.Where(w => w.NatID == Member.NationalId).FirstOrDefault().NatNameKh;
        Member.Relationship = Relationships.Where(w => w.RelId == Member.RelId).FirstOrDefault().RelDesc;
        Member.Phone = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "memphone");

        await this.OnSubmit.InvokeAsync(Tuple.Create(Index, Member));
    }



    async Task OnAddDocument(int index, ClaimDocumentModel doc)
    {
        int countCheck = Member.Documents.Where(w => w.DocID == doc.DocID).Count();

        ClaimFamilyMemberDocumentModel document = new ClaimFamilyMemberDocumentModel()
        {
            Active = true,
            DocAt = doc.DocAt,
            DocBy = doc.DocBy,
            DocCode = doc.DocCode,
            DocDate = doc.DocDate,
            DocID = doc.DocID,
            DocName = Documents.Where(w => w.DocID == doc.DocID).SingleOrDefault().DocName,
            MemId = Member.MemId
        };



        if (index == -1 && countCheck == 0)
        {
            Member.Documents.Add(document);
            await DocumentModal.Close();
        }
        //UPDATE
        else if (index >= 0 && countCheck == 1)
        {
            Member.Documents.RemoveAt(index);
            Member.Documents.Insert(index, document);
            await DocumentModal.Close();
        }
        else await MessageBox.Show(MessageTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
        StateHasChanged();
    }



    [JSInvokable]
    public async Task OnSexChanged(object val)
    {
        this.Relationships = await ConstantValue.GetRelationShips(val.ToString());
        Member.RelId = Relationships.FirstOrDefault().RelId;
        this.StateHasChanged();
    }

    private void OnRemoveDocument(int index)
    {
        Member.Documents.RemoveAt(index);
    }

    public async Task Close()
    {
        await MyModal.Close();
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591