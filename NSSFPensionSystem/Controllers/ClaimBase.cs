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
    public class ClaimBase : ComponentBase
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
        public ClaimFamilyMemberModel CurrentMember = new ClaimFamilyMemberModel();
        public ClaimFamilyMemberDocumentModel CurrentMemberDoc = new ClaimFamilyMemberDocumentModel();
        
        public List<ClaimFamilyMemberDocumentModel> CurrentMemberDocList = new List<ClaimFamilyMemberDocumentModel>();
        public int MemberDocumentSelectedIndex = -1;

        public List<ClaimDocumentModel> ClaimDocumentList = new List<ClaimDocumentModel>();
        public int ClaimDocumentSelectedIndex = -1;

        public List<ClaimFamilyMemberModel> MemberList = new List<ClaimFamilyMemberModel>();
        public int MemberSelectedIndex = -1;

        public List<String> TableHeaderDocument = new List<string>() { "ល.រ", "ប្រភេទឯកសារ", "លេខលិខិត", "ថ្ងៃខែឆ្នាំចុះលិខិត", "ចេញលិខិតដោយ", "ចេញលិខិតនៅ", "សកម្មភាព" };
        public List<String> TableHeaderMember = new List<string>() { "ល.រ", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ត្រូវជា", "សញ្ជាតិ", "លេខទូរស័ព្ទ", "សកម្មភាព" };

        public Modal ModalClaimDocument { get; set; }
        public Modal ModalMember { get; set; }
        public Modal ModalMemberDoc { get; set; }
        public MessageBox MessageBox { get; set; }
        #endregion



        protected override async Task OnInitializedAsync()
        {
            this.Nationalities = await ConstantValue.GetNationalities();
            this.Documents = await ConstantValue.GetDocuments();
            this.Genders = await ConstantValue.GetGender();
            if (this.Genders != null && this.Genders.Count > 0)
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

        public void OnMessageBoxConfirmation(bool result, ConfirmFor confirmFor)
        {
            if (result)
            {
                if (confirmFor == ConfirmFor.CLAIM_DOCUMENT)
                {
                    ClaimDocumentList.RemoveAt(ClaimDocumentSelectedIndex);
                    ClaimDocumentSelectedIndex = -1;
                }
                else if (confirmFor == ConfirmFor.CLAIM_MEMBER_DOCUMENT)
                {
                    CurrentMemberDocList.RemoveAt(MemberDocumentSelectedIndex);
                    MemberDocumentSelectedIndex = -1;
                }
                else if (confirmFor == ConfirmFor.CLAIM_MEMBER)
                {
                    MemberList.RemoveAt(MemberSelectedIndex);
                    MemberSelectedIndex = -1;
                }    
            }
            StateHasChanged();
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
            this.Districts = await ConstantValue.GetDistricts(Convert.ToInt32(val.ToString()));

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


        public async void OnAddClaimDocument(EventArgs e)
        {
            int countCheck = ClaimDocumentList.Where(w => w.DocID == CurrentDocment.DocID).Count();
            if (CurrentDocment == null)
            {
                await MessageBox.Show(MessageBoxTypes.WARNING, "សូមបញ្ចូលព័ត៌មានឯកសារឲ្យបានត្រឹមត្រូវ!");
                return;
            }

            CurrentDocment.DocName = Documents.Where(w => w.DocID == CurrentDocment.DocID).FirstOrDefault().DocName;
            if (ClaimDocumentSelectedIndex == -1) //ADD
            {
                if(countCheck > 0)
                {
                    await MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                ClaimDocumentList.Add(CurrentDocment);
            }
            else //UPDATE
            {
                if (countCheck > 1)
                {
                    await MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                ClaimDocumentList.RemoveAt(ClaimDocumentSelectedIndex);
                ClaimDocumentList.Insert(ClaimDocumentSelectedIndex, CurrentDocment);
            }

            CurrentDocment = new ClaimDocumentModel() { DocID = 1 };
            ClaimDocumentSelectedIndex = -1;
            StateHasChanged();
            ModalClaimDocument.Close();
        }
        public async Task OnRemoveClaimDocument(int index)
        {
            ClaimDocumentSelectedIndex = index;
            await MessageBox.Show(MessageBoxTypes.CONFIRM, ConfirmFor.CLAIM_DOCUMENT, "តើអ្នកពិតជាចង់ដកចេញមែនទេ?");
        }

        public async void OnAddMemberDocument(EventArgs e)
        {
            int countCheck = CurrentMemberDocList.Where(w => w.DocID == CurrentMemberDoc.DocID).Count();
            if (CurrentMemberDoc == null)
            {
                await MessageBox.Show(MessageBoxTypes.WARNING, "សូមបញ្ចូលព័ត៌មានឯកសារឲ្យបានត្រឹមត្រូវ!");
                return;
            }

            CurrentMemberDoc.DocName = Documents.Where(w => w.DocID == CurrentMemberDoc.DocID).FirstOrDefault().DocName;
            if (MemberDocumentSelectedIndex == -1)
            {
                if (countCheck > 0)
                {
                    await MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                CurrentMemberDocList.Add(CurrentMemberDoc);
            }
            else
            {
                if (countCheck > 1)
                {
                    await MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                CurrentMemberDocList.RemoveAt(MemberDocumentSelectedIndex);
                CurrentMemberDocList.Insert(MemberDocumentSelectedIndex, CurrentMemberDoc);
            }
            
            CurrentMemberDoc = new ClaimFamilyMemberDocumentModel() { DocID = CurrentMemberDoc.DocID };
            MemberDocumentSelectedIndex = -1;
            StateHasChanged();
            ModalMemberDoc.Close();
        }


        

        public async void OnRemoveMemberDoc(int index)
        {
            MemberDocumentSelectedIndex = index;
            await MessageBox.Show(MessageBoxTypes.CONFIRM, ConfirmFor.CLAIM_MEMBER_DOCUMENT, "តើអ្នកពិតជាចង់ដកចេញមែនទេ?");
        }


        public void OnEditClaimDocument(int index)
        {
            ClaimDocumentSelectedIndex = index;
            ClaimDocumentModel selected = ClaimDocumentList[ClaimDocumentSelectedIndex];
            CurrentDocment = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimDocumentModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));

            StateHasChanged();
            ModalClaimDocument.Open();
        }

        public void OnEditMemberDocument(int index)
        {
            MemberDocumentSelectedIndex = index;
            ClaimFamilyMemberDocumentModel selected = CurrentMemberDocList[MemberDocumentSelectedIndex];
            CurrentMemberDoc = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimFamilyMemberDocumentModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));

            StateHasChanged();
            ModalMemberDoc.Open();
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


        public async void OnAddMember(EventArgs e)
        {
            List<string> validatMsg = new List<string>();
            if (CurrentMember.FirstNameKh.Trim().Length == 0 || CurrentMember.LastNameKh.Trim().Length == 0)
                validatMsg.Add("- សូមបញ្ចូលគោត្តនាម និងនាមឲ្យបានត្រឹមត្រូវ!");
            else if (CurrentMember.Dob == null)
                validatMsg.Add("- សូមបញ្ចូលថ្ងៃខែឆ្នាំកំណើតឲ្យបានត្រឹមត្រូវ!");

            if(validatMsg.Count > 0)
            {
                await MessageBox.Show(MessageBoxTypes.WARNING, string.Join("\n", validatMsg));
                return;
            }
            


            CurrentMember.Documents = new List<ClaimFamilyMemberDocumentModel>();
            CurrentMember.Documents.AddRange(CurrentMemberDocList);
            CurrentMember.Nationality = Nationalities.Where(w => w.NatID == CurrentMember.NationalId).FirstOrDefault().NatNameKh;
            CurrentMember.Relationship = Relationships.Where(w => w.RelId == CurrentMember.RelId).FirstOrDefault().RelDesc;

            if (MemberSelectedIndex == -1)
            {
                MemberList.Add(CurrentMember);
            }
            else
            {
                MemberList.RemoveAt(MemberSelectedIndex);
                MemberList.Insert(MemberSelectedIndex, CurrentMember);
            }

            StateHasChanged();
            CurrentMemberDocList = new List<ClaimFamilyMemberDocumentModel>();
            CurrentMember = new ClaimFamilyMemberModel();
            MemberSelectedIndex = -1;
            StateHasChanged();
            ModalMember.Close();
        }

        public void OnEditMember(int index)
        {
            MemberSelectedIndex = index;
            ClaimFamilyMemberModel selected = MemberList[MemberSelectedIndex];
            CurrentMember = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimFamilyMemberModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));
            CurrentMemberDocList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClaimFamilyMemberDocumentModel>>(Newtonsoft.Json.JsonConvert.SerializeObject(selected.Documents));

            StateHasChanged();
            ModalMember.Open();
        }

        public async void OnRemoveMember(int index)
        {
            MemberSelectedIndex = index;
            await MessageBox.Show(MessageBoxTypes.CONFIRM, ConfirmFor.CLAIM_MEMBER, "តើអ្នកពិតជាចង់ដកចេញមែនទេ?");
        }
    }
}

