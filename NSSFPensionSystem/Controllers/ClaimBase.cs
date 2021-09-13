using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Models;

namespace NSSFPensionSystem.Controllers
{
    public class ClaimBase: ComponentBase
    {
     
        #region INJECT
        [Inject]
        private IJSRuntime Runtime { get; set; }

        [Inject]
        private IConstantValueService ConstantValue { get; set; }
        #endregion



        #region PROPERTIES
        private DotNetObjectReference<ClaimBase> objRef;
        public List<NationalityModel> Nationalities = new List<NationalityModel>();
        public List<DocumentModel> Documents = new List<DocumentModel>();
        public List<ProvinceModel> Provinces = new List<ProvinceModel>();
        public List<DistrictModel> Districts = new List<DistrictModel>();
        public List<CommuneModel> Communes = new List<CommuneModel>();
        public List<GenderModel> Genders = new List<GenderModel>();
        public List<RelationshipModel> Relationships = new List<RelationshipModel>();

        public ClaimDocumentModel CurrentDocment = new ClaimDocumentModel() { DocID = 1};
        public ClaimFamilyMemberModel CurrentMember = new ClaimFamilyMemberModel();
        public ClaimFamilyMemberDocumentModel CurrentMemberDoc = new ClaimFamilyMemberDocumentModel();
        public List<ClaimFamilyMemberDocumentModel> CurrentMemberDocs = new List<ClaimFamilyMemberDocumentModel>();

        public List<ClaimDocumentModel> ClaimDocuments = new List<ClaimDocumentModel>();
        public List<ClaimFamilyMemberModel> Members = new List<ClaimFamilyMemberModel>();

        public List<String> TableHeaderDocument = new List<string>() { "ល.រ", "ប្រភេទឯកសារ", "លេខលិខិត", "ថ្ងៃខែឆ្នាំចុះលិខិត", "ចេញលិខិតដោយ", "ចេញលិខិតនៅ", "លុប"};
        public List<String> TableHeaderMember = new List<string>() { "ល.រ", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ទំនាក់ទំនង", "ស្ថានភាពសុខភាព", "សញ្ជាតិ", "អ្នកតំណាង", "អ្នកថែរក្សា", "ចំនួនឯកសារភ្ជាប់" };


        #endregion



        protected override async Task OnInitializedAsync()
        {
            this.Nationalities = await ConstantValue.GetNationalities();
            this.Documents = await ConstantValue.GetDocuments();
            this.Genders = await ConstantValue.GetGender();
            if(this.Genders != null && this.Genders.Count > 0)
            {
                await this.GetRelationships(this.Genders.FirstOrDefault().GenID);
            }
            
            this.Provinces = await ConstantValue.GetProvices();
            if (this.Provinces != null && this.Provinces.Count > 0)
            {
                this.Districts = await ConstantValue.GetDistricts(this.Provinces[0].ProID);
                if (this.Districts != null && this.Districts.Count > 0)
                {
                    await GetCommunes(this.Districts.FirstOrDefault().DisID);
                }
            }
        }



        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            if (firstRender)
            {
                objRef = DotNetObjectReference.Create(this);
                await Runtime.InvokeAsync<object>("ClaimJS", objRef);
                StateHasChanged();
            }
        }

        [JSInvokable]
        public void OnBenIDChanged(object e)
        {
            
        }


        [JSInvokable]
        public async Task GetDistricts(object val)
        {
            this.Districts = new List<DistrictModel>();
            StateHasChanged();
            this.Districts = await  ConstantValue.GetDistricts(Convert.ToInt32(val.ToString()));

            this.StateHasChanged();
            if (this.Districts != null && this.Districts.Count > 0)
            {
                await GetCommunes(this.Districts.FirstOrDefault().DisID);
            }
            
        }

        [JSInvokable]
        public async Task GetCommunes(object val)
        {
            this.Communes = new List<CommuneModel>();
            StateHasChanged();
            this.Communes = await ConstantValue.GetCommunes(Convert.ToInt32(val.ToString()));
            this.StateHasChanged();
        }


        public void OnAddClaimDocument(EventArgs e)
        {
            if(CurrentDocment != null && ClaimDocuments.Where(w=> w.DocID == CurrentDocment.DocID).Count() < 1)
            {
                CurrentDocment.DocName = Documents.Where(w => w.DocID == CurrentDocment.DocID).FirstOrDefault().DocName;
                ClaimDocuments.Add(CurrentDocment);
            }
            CurrentDocment = new ClaimDocumentModel() { DocID = 1};
        }


        public void OnAddMemberDocument(EventArgs e)
        {
            if (CurrentMemberDoc != null && CurrentMemberDocs.Where(w => w.DocID == CurrentMemberDoc.DocID).Count() < 1)
            {
                CurrentMemberDoc.DocName = Documents.Where(w => w.DocID == CurrentMemberDoc.DocID).FirstOrDefault().DocName;
                CurrentMemberDocs.Add(CurrentMemberDoc);
                StateHasChanged();
            }
            CurrentMemberDoc = new ClaimFamilyMemberDocumentModel() { DocID = 1 };
            StateHasChanged();
        }


        [JSInvokable]
        public void OnRemoveClaimDocument(int index)
        {
            ClaimDocuments.RemoveAt(index);
            this.StateHasChanged();
        }


        [JSInvokable]
        public async Task GetRelationships(object val)
        {
            this.Communes = new List<CommuneModel>();
            StateHasChanged();
            this.Relationships = await ConstantValue.GetRelationShips(val.ToString());
            this.StateHasChanged();
        }


        public void OnAddMember(EventArgs e)
        {
            CurrentMember.Documents = new List<ClaimFamilyMemberDocumentModel>();
            CurrentMember.Documents.AddRange(CurrentMemberDocs);
            Members.Add(CurrentMember);
            StateHasChanged();
            
            CurrentMemberDocs = new List<ClaimFamilyMemberDocumentModel>();
            CurrentMember = new ClaimFamilyMemberModel();
            StateHasChanged();
        }
    }
}

