using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Shared;
using AutoMapper;
using NSSFPensionSystem.Setting;

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

        public ClaimDocumentModel CurrentDocment = new ClaimDocumentModel() { DocID = 1 };
        public int CurrentDocumentSelectedIndex = -1;
        public ClaimFamilyMemberModel CurrentMember = new ClaimFamilyMemberModel();
        public int CurrentMemberSelectedIndex = -1;
        public ClaimFamilyMemberDocumentModel CurrentMemberDoc = new ClaimFamilyMemberDocumentModel();
        public int CurrentMemberDocSelectedIndex = -1;
        public List<ClaimFamilyMemberDocumentModel> CurrentMemberDocs = new List<ClaimFamilyMemberDocumentModel>();

        public List<ClaimDocumentModel> ClaimDocuments = new List<ClaimDocumentModel>();
        public List<ClaimFamilyMemberModel> Members = new List<ClaimFamilyMemberModel>();

        public List<String> TableHeaderDocument = new List<string>() { "ល.រ", "ប្រភេទឯកសារ", "លេខលិខិត", "ថ្ងៃខែឆ្នាំចុះលិខិត", "ចេញលិខិតដោយ", "ចេញលិខិតនៅ", "សកម្មភាព"};
        public List<String> TableHeaderMember = new List<string>() { "ល.រ", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ត្រូវជា", "សញ្ជាតិ", "លេខទូរស័ព្ទ", "សកម្មភាព"};

        public Modal ModalClaimDocument { get; set; }
        public Modal ModalMember { get; set; }
        public Modal ModalMemberDoc { get; set; }
        public MessageBox MessageBox { get; set; }
        public bool MessageBoxResult { get; set; } = false;
        #endregion



        protected override async Task OnInitializedAsync()
        {
            this.Nationalities = await ConstantValue.GetNationalities();
            this.Documents = await ConstantValue.GetDocuments();
            this.Genders = await ConstantValue.GetGender();
            if(this.Genders != null && this.Genders.Count > 0)
            {
                await this.OnSexChanged(this.Genders.FirstOrDefault().GenID);
            }
            
            this.Provinces = await ConstantValue.GetProvices();
            if (this.Provinces != null && this.Provinces.Count > 0)
            {
                this.Districts = await ConstantValue.GetDistricts(this.Provinces[0].ProID);
                if (this.Districts != null && this.Districts.Count > 0)
                {
                    await OnDistrictChange(this.Districts.FirstOrDefault().DisID);
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

        public void OnMessageBoxConfirmation(bool val)
        {
            if(val == true)
            {

            }
            MessageBoxResult = val;
        }


        [JSInvokable]
        public void OnBenIDChanged(object e)
        {
            
        }


        [JSInvokable]
        public async Task OnProvinceChanged(object val)
        {
            this.Districts = new List<DistrictModel>();
            StateHasChanged();
            this.Districts = await  ConstantValue.GetDistricts(Convert.ToInt32(val.ToString()));

            this.StateHasChanged();
            if (this.Districts != null && this.Districts.Count > 0)
            {
                await OnDistrictChange(this.Districts.FirstOrDefault().DisID);
            }
            
        }

        [JSInvokable]
        public async Task OnDistrictChange(object val)
        {
            this.Communes = new List<CommuneModel>();
            StateHasChanged();
            this.Communes = await ConstantValue.GetCommunes(Convert.ToInt32(val.ToString()));
            this.StateHasChanged();
        }


        public void OnAddClaimDocument(EventArgs e)
        {
            if(this.CurrentDocumentSelectedIndex == -1)
            {
                if (CurrentDocment != null && ClaimDocuments.Where(w => w.DocID == CurrentDocment.DocID).Count() < 1)
                {
                    CurrentDocment.DocName = Documents.Where(w => w.DocID == CurrentDocment.DocID).FirstOrDefault().DocName;
                    ClaimDocuments.Add(CurrentDocment);
                }
            }
            else
            {
                ClaimDocuments.RemoveAt(CurrentDocumentSelectedIndex);
                CurrentDocment.DocName = Documents.Where(w => w.DocID == CurrentDocment.DocID).FirstOrDefault().DocName;
                ClaimDocuments.Insert(CurrentDocumentSelectedIndex, CurrentDocment);
            }
            
            CurrentDocment = new ClaimDocumentModel() { DocID = 1};
            CurrentDocumentSelectedIndex = -1;
            StateHasChanged();
            ModalClaimDocument.Close();
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
            ModalMemberDoc.Close();
        }


        public void OnRemoveClaimDocument(int index)
        {
            CurrentDocumentSelectedIndex = index;
            MessageBox.Open(MessageBoxTypes.Confirm, "Are you sure?");
            MessageBoxResult = MessageBox.Result;
            if (MessageBoxResult)
            {
                ClaimDocuments.RemoveAt(CurrentDocumentSelectedIndex);
                StateHasChanged();
            }
        }

        public void OnRemoveMemberDoc(int index)
        {
            CurrentMemberDocs.RemoveAt(index);
            StateHasChanged();
        }

        public void OnRemoveMember(int index)
        {
            Members.RemoveAt(index);
            StateHasChanged();
        }

        public void OnConfirmRemoveClaimDocument(bool confirmed)
        {
            if(confirmed)
            {
                ClaimDocuments.RemoveAt(CurrentDocumentSelectedIndex);
                StateHasChanged();
            }
            CurrentDocumentSelectedIndex = -1;
        }


        public void OnEditClaimDocument(int index)
        {
            CurrentDocumentSelectedIndex = index;
            ClaimDocumentModel selected = ClaimDocuments[index];
            CurrentDocment = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimDocumentModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));
            
            StateHasChanged();
            ModalClaimDocument.Open();
        }

        public void OnEditMemberDocument(int index)
        {
            CurrentMemberDocSelectedIndex = index;
            ClaimFamilyMemberDocumentModel selected = CurrentMemberDocs[index];
            CurrentMemberDoc = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimFamilyMemberDocumentModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));

            StateHasChanged();
            ModalMemberDoc.Open();
        }


        public void OnEditMember(int index)
        {
            CurrentMemberSelectedIndex = index;
            ClaimFamilyMemberModel selected = Members[index];
            CurrentMember = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimFamilyMemberModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));
            CurrentMemberDocs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClaimFamilyMemberDocumentModel>>(Newtonsoft.Json.JsonConvert.SerializeObject(selected.Documents));

            StateHasChanged();
            ModalMember.Open();
        }


        [JSInvokable]
        public async Task OnSexChanged(object val)
        {
            this.Communes = new List<CommuneModel>();
            StateHasChanged();
            this.Relationships = await ConstantValue.GetRelationShips(val.ToString());
            this.CurrentMember.RelId = Relationships.FirstOrDefault().RelId;
            this.StateHasChanged();
        }


        public void OnAddMember(EventArgs e)
        {
            CurrentMember.Documents = new List<ClaimFamilyMemberDocumentModel>();
            CurrentMember.Documents.AddRange(CurrentMemberDocs);
            CurrentMember.Nationality = Nationalities.Where(w => w.NatID == CurrentMember.NationalId).FirstOrDefault().NatNameKh;
            CurrentMember.Relationship = Relationships.Where(w => w.RelId == CurrentMember.RelId).FirstOrDefault().RelDesc;

            if (CurrentMemberSelectedIndex == -1)
            {
                Members.Add(CurrentMember);
            }
            else
            {
                Members.RemoveAt(CurrentMemberSelectedIndex);
                Members.Insert(CurrentMemberSelectedIndex, CurrentMember);
            }

            StateHasChanged();
            CurrentMemberDocs = new List<ClaimFamilyMemberDocumentModel>();
            CurrentMember = new ClaimFamilyMemberModel();
            CurrentMemberSelectedIndex = -1;
            StateHasChanged();
            ModalMember.Close();
        }
    }
}

