using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Shared.Components;
using NSSFPensionSystem.Setting;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Controllers
{
    public class ClaimBase : ComponentBase
    {

        [Parameter]
        public Guid Id { get; set; }



        #region INJECT
        [Inject]
        private IJSRuntime Runtime { get; set; }

        [Inject]
        private IConstantValueService ConstantValue { get; set; }

        [Inject]
        private IClaimService ClaimService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }
        #endregion



        #region PROPERTIES
        private DotNetObjectReference<ClaimBase> objRef;
        protected bool AllowEdit = false;
        public ClaimModel Claim = new ClaimModel();
        public List<NationalityModel> Nationalities = new List<NationalityModel>();
        public List<DocumentModel> Documents = new List<DocumentModel>();
        public List<ProvinceModel> Provinces = new List<ProvinceModel>();
        public List<DistrictModel> Districts = new List<DistrictModel>();
        public List<CommuneModel> Communes = new List<CommuneModel>();
        public List<GenderModel> Genders = new List<GenderModel>();
        public List<RelationshipModel> Relationships = new List<RelationshipModel>();
        public List<BankModel> Banks = new List<BankModel>();
        public List<PensionTypeModel> PensionTypes = new List<PensionTypeModel>();

        public ClaimDocumentModel CurrentDocment = new ClaimDocumentModel() { DocID = 1 };
        public ClaimFamilyMemberModel CurrentMember = new ClaimFamilyMemberModel();
        public ClaimFamilyMemberDocumentModel CurrentMemberDoc = new ClaimFamilyMemberDocumentModel();
        
        //public List<ClaimFamilyMemberDocumentModel> CurrentMemberDocList = new List<ClaimFamilyMemberDocumentModel>();
        public int MemberDocumentSelectedIndex = -1;

        //public List<ClaimDocumentModel> ClaimDocumentList = new List<ClaimDocumentModel>();
        public int ClaimDocumentSelectedIndex = -1;

        //public List<ClaimFamilyMemberModel> MemberList = new List<ClaimFamilyMemberModel>();
        public int MemberSelectedIndex = -1;

        public List<String> TableHeaderDocument = new List<string>() { "ល.រ", "ប្រភេទឯកសារ", "លេខលិខិត", "ថ្ងៃខែឆ្នាំចុះលិខិត", "ចេញលិខិតដោយ", "ចេញលិខិតនៅ", "សកម្មភាព" };
        public List<String> TableHeaderMember = new List<string>() { "ល.រ", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ត្រូវជា", "សញ្ជាតិ", "លេខទូរស័ព្ទ", "សកម្មភាព" };

        public Modal ModalClaimDocument { get; set; }
        public Modal ModalMember { get; set; }
        public Modal ModalMemberDoc { get; set; }
        public MessageBox MessageBox { get; set; }

        protected bool IsBusy = false;
        #endregion



        protected override async Task OnInitializedAsync()
        {
            this.Nationalities = await ConstantValue.GetNationalities();
            this.Documents = await ConstantValue.GetDocuments();
            this.Genders = await ConstantValue.GetGender();
            this.Banks = await ConstantValue.GetBanks();
            this.PensionTypes = await ConstantValue.GetPensionTypes();
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
            
            if (firstRender)
            {
                objRef = DotNetObjectReference.Create(this);
                await Runtime.InvokeAsync<object>("ClaimJS", objRef);
                StateHasChanged();
            }

            base.OnAfterRender(firstRender);
        }


        //public override async Task SetParametersAsync(ParameterView parameters)
        //{
            //try
            //{
            //    if (parameters.TryGetValue<Guid>(nameof(Id), out var result))
            //    {
            //        if (result != null && result.ToString().Length == 36 && result.ToString() != "00000000-0000-0000-0000-000000000000")
            //        {
            //            this.Claim = await ClaimService.GetClaim(result.ToString());
            //            await this.OnProvinceChanged(this.Claim.ProId);
            //            await this.OnDistrictChange(this.Claim.DisId);

            //            if (Claim.StatusId == 1)
            //            {
            //                AllowEdit = true;
            //            }
            //        }
            //    }
            //    await base.SetParametersAsync(parameters);
            //}
            //catch(Exception ex) { MessageBox.Show(MessageBoxTypes.ERROR, ex.Message); }
            //finally { StateHasChanged(); }
        //}


        protected async override Task OnParametersSetAsync()
        {
            try
            {
                    if (Id != null && Id.ToString().Length == 36 && Id.ToString() != "00000000-0000-0000-0000-000000000000")
                    {
                        this.Claim = await ClaimService.GetClaim(Id.ToString());
                        await this.OnProvinceChanged(this.Claim.ProId);
                        await this.OnDistrictChange(this.Claim.DisId);

                        if (Claim.StatusId == 1)
                        {
                            AllowEdit = true;
                        }
                    }
            }
            catch (Exception ex) { MessageBox.Show(MessageBoxTypes.ERROR, ex.Message); }
            finally { StateHasChanged(); }


            await base.OnParametersSetAsync();
        }


        public void OnMessageBoxConfirmation(bool result, ConfirmFor confirmFor)
        {
            if (result)
            {
                if (confirmFor == ConfirmFor.CLAIM_DOCUMENT)
                {
                    this.Claim.Documents.RemoveAt(ClaimDocumentSelectedIndex);
                    //ClaimDocumentList.RemoveAt(ClaimDocumentSelectedIndex);
                    ClaimDocumentSelectedIndex = -1;
                }
                else if (confirmFor == ConfirmFor.CLAIM_MEMBER_DOCUMENT)
                {
                    this.CurrentMember.Documents.RemoveAt(MemberDocumentSelectedIndex);
                    //CurrentMemberDocList.RemoveAt(MemberDocumentSelectedIndex);
                    MemberDocumentSelectedIndex = -1;
                }
                else if (confirmFor == ConfirmFor.CLAIM_MEMBER)
                {
                    this.Claim.Members.RemoveAt(MemberSelectedIndex);
                    //MemberList.RemoveAt(MemberSelectedIndex);
                    MemberSelectedIndex = -1;
                }
            }
            StateHasChanged();
        }

        [JSInvokable]
        public async void OnBenIdCompleted(object e)
        {
            try
            {
                string benId = e.ToString();
                ClaimPensionerModel pensioner = await ClaimService.GetPensioner(benId);


                if (pensioner == null)
                {
                    MessageBox.Show(MessageBoxTypes.WARNING, "ទិន្នន័យមិនមាននៅក្នុងប្រព័ន្ធ!");
                    StateHasChanged();
                    return;
                }


                Claim.BenId = benId;
                Claim.Pensioner = pensioner;
                StateHasChanged();
            }
            catch(Exception ex)
            {
                MessageBox.Show(MessageBoxTypes.ERROR, ex.Message);
                StateHasChanged();
            }
        }

        [JSInvokable]
        public void OnBenIdInCompleted(object e)
        {
            Claim.Pensioner = new ClaimPensionerModel();
            StateHasChanged();
        }


        [JSInvokable]
        public async Task OnProvinceChanged(object val)
        {
            this.Districts = new List<DistrictModel>();
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
            this.Communes = await ConstantValue.GetCommunes(Convert.ToInt32(val.ToString()));
        }


        public void OnNewClaimDocumentModal()
        {
            ModalClaimDocument.Open();
            ClaimDocumentSelectedIndex = -1;
            CurrentDocment = new ClaimDocumentModel();
            StateHasChanged();
        }

        public void OnNewMemberModal()
        {
            ModalMember.Open();
            MemberSelectedIndex = -1;
            CurrentMember = new ClaimFamilyMemberModel();
            //CurrentMemberDocList = new List<ClaimFamilyMemberDocumentModel>();
            StateHasChanged();
        }

        public void OnNewMemberDocumentModal()
        {
            ModalMemberDoc.Open();
            MemberDocumentSelectedIndex = -1;
            CurrentMemberDoc = new ClaimFamilyMemberDocumentModel();
            StateHasChanged();
        }


        public void OnAddClaimDocument(EventArgs e)
        {
            int countCheck = Claim.Documents.Where(w => w.DocID == CurrentDocment.DocID).Count();
            //int countCheck = ClaimDocumentList.Where(w => w.DocID == CurrentDocment.DocID).Count();
            if (CurrentDocment == null)
            {
                MessageBox.Show(MessageBoxTypes.WARNING, "សូមបញ្ចូលព័ត៌មានឯកសារឲ្យបានត្រឹមត្រូវ!");
                return;
            }

            
            if (ClaimDocumentSelectedIndex == -1) //ADD
            {
                if(countCheck > 0)
                {
                    MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                Claim.Documents.Add(CurrentDocment);
                //ClaimDocumentList.Add(CurrentDocment);
            }
            else //UPDATE
            {
                if (countCheck > 1)
                {
                    MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                Claim.Documents.RemoveAt(ClaimDocumentSelectedIndex);
                Claim.Documents.Insert(ClaimDocumentSelectedIndex, CurrentDocment);
                //ClaimDocumentList.RemoveAt(ClaimDocumentSelectedIndex);
                //ClaimDocumentList.Insert(ClaimDocumentSelectedIndex, CurrentDocment);
            }

            CurrentDocment = new ClaimDocumentModel() { DocID = 1 };
            ClaimDocumentSelectedIndex = -1;
            ModalClaimDocument.Close();
            StateHasChanged();
        }
        public void OnRemoveClaimDocument(int index)
        {
            ClaimDocumentSelectedIndex = index;
            MessageBox.Show(MessageBoxTypes.CONFIRM, ConfirmFor.CLAIM_DOCUMENT, "តើអ្នកពិតជាចង់ដកចេញមែនទេ?");
        }

        public void OnAddMemberDocument(EventArgs e)
        {
            int countCheck = Claim.Members[MemberSelectedIndex].Documents.Where(w => w.DocID == CurrentMemberDoc.DocID).Count();
            //int countCheck = CurrentMemberDocList.Where(w => w.DocID == CurrentMemberDoc.DocID).Count();
            if (CurrentMemberDoc == null)
            {
                MessageBox.Show(MessageBoxTypes.WARNING, "សូមបញ្ចូលព័ត៌មានឯកសារឲ្យបានត្រឹមត្រូវ!");
                return;
            }

            CurrentMemberDoc.DocName = Documents.Where(w => w.DocID == CurrentMemberDoc.DocID).FirstOrDefault().DocName;
            if (MemberDocumentSelectedIndex == -1)
            {
                if (countCheck > 0)
                {
                    MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                CurrentMember.Documents.Add(CurrentMemberDoc);
                //CurrentMemberDocList.Add(CurrentMemberDoc);
            }
            else
            {
                if (countCheck > 1)
                {
                    MessageBox.Show(MessageBoxTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
                    return;
                }
                CurrentMember.Documents.RemoveAt(MemberDocumentSelectedIndex);
                CurrentMember.Documents.Insert(MemberDocumentSelectedIndex, CurrentMemberDoc);
                //CurrentMemberDocList.RemoveAt(MemberDocumentSelectedIndex);
                //CurrentMemberDocList.Insert(MemberDocumentSelectedIndex, CurrentMemberDoc);
            }
            
            CurrentMemberDoc = new ClaimFamilyMemberDocumentModel() { DocID = CurrentMemberDoc.DocID };
            MemberDocumentSelectedIndex = -1;
            StateHasChanged();
            ModalMemberDoc.Close();
        }


        

        public void OnRemoveMemberDoc(int index)
        {
            MemberDocumentSelectedIndex = index;
            MessageBox.Show(MessageBoxTypes.CONFIRM, ConfirmFor.CLAIM_MEMBER_DOCUMENT, "តើអ្នកពិតជាចង់ដកចេញមែនទេ?");
        }


        public void OnEditClaimDocument(int index)
        {
            ClaimDocumentSelectedIndex = index;
            ClaimDocumentModel selected = Claim.Documents[ClaimDocumentSelectedIndex];
            //ClaimDocumentModel selected = ClaimDocumentList[ClaimDocumentSelectedIndex];
            CurrentDocment = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimDocumentModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));

            StateHasChanged();
            ModalClaimDocument.Open();
        }

        public void OnEditMemberDocument(int index)
        {
            MemberDocumentSelectedIndex = index;
            ClaimFamilyMemberDocumentModel selected = Claim.Members[MemberSelectedIndex].Documents[MemberDocumentSelectedIndex];
            //ClaimFamilyMemberDocumentModel selected = CurrentMemberDocList[MemberDocumentSelectedIndex];
            CurrentMemberDoc = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimFamilyMemberDocumentModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));

            StateHasChanged();
            ModalMemberDoc.Open();
        }


        [JSInvokable]
        public async Task OnSexChanged(object val)
        {
            this.Communes = new List<CommuneModel>();
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
                MessageBox.Show(MessageBoxTypes.WARNING, string.Join("\n", validatMsg));
                return;
            }


            //CurrentMember.Documents = new List<ClaimFamilyMemberDocumentModel>();
            //CurrentMember.Documents.AddRange(CurrentMemberDocList);
            CurrentMember.Nationality = Nationalities.Where(w => w.NatID == CurrentMember.NationalId).FirstOrDefault().NatNameKh;
            CurrentMember.Relationship = Relationships.Where(w => w.RelId == CurrentMember.RelId).FirstOrDefault().RelDesc;
            CurrentMember.Phone = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "memphone");

            if (MemberSelectedIndex == -1)
            {
                this.Claim.Members.Add(CurrentMember);
                //MemberList.Add(CurrentMember);
            }
            else
            {
                this.Claim.Members.RemoveAt(MemberSelectedIndex);
                this.Claim.Members.Insert(MemberSelectedIndex, CurrentMember);
                //MemberList.RemoveAt(MemberSelectedIndex);
                //MemberList.Insert(MemberSelectedIndex, CurrentMember);
            }

            //CurrentMemberDocList = new List<ClaimFamilyMemberDocumentModel>();
            CurrentMember = new ClaimFamilyMemberModel();
            MemberSelectedIndex = -1;
            ModalMember.Close();
            StateHasChanged();
        }

        public void OnEditMember(int index)
        {
            MemberSelectedIndex = index;
            ClaimFamilyMemberModel selected = this.Claim.Members[MemberSelectedIndex];
            //ClaimFamilyMemberModel selected = MemberList[MemberSelectedIndex];
            CurrentMember = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimFamilyMemberModel>(Newtonsoft.Json.JsonConvert.SerializeObject(selected));
            //CurrentMemberDocList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClaimFamilyMemberDocumentModel>>(Newtonsoft.Json.JsonConvert.SerializeObject(selected.Documents));

            StateHasChanged();
            ModalMember.Open();
        }

        public void OnRemoveMember(int index)
        {
            MemberSelectedIndex = index;
            MessageBox.Show(MessageBoxTypes.CONFIRM, ConfirmFor.CLAIM_MEMBER, "តើអ្នកពិតជាចង់ដកចេញមែនទេ?");
        }

        public async void OnSave(EventArgs e)
        {
            try
            {
                IsBusy = true;
                //if (Claim.ClaId == 0)
                //{
                    //Claim.Documents = new List<ClaimDocumentModel>();
                    //Claim.Documents.AddRange(ClaimDocumentList);
                    //Claim.Members = new List<ClaimFamilyMemberModel>();
                    //Claim.Members.AddRange(MemberList);
                    Claim.EntId = Claim.Pensioner.EntId;
                    Claim.NationalId = Claim.Pensioner.BenNationalityId;
                    Claim.IdNumber = Claim.Pensioner.BenIdcard;
                    Claim.Phone1 = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "phone1");
                    Claim.Phone2 = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "phone2");
                    
                    var result = await ClaimService.Save(Claim);
                    Claim = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimModel>(Newtonsoft.Json.JsonConvert.SerializeObject(result));
                    
                MessageBox.Show(MessageBoxTypes.INFO, "ប្រតិបត្តិការទទួលបានជោគជ័យ!");
                StateHasChanged();
                ////}
            }
            catch(Exception ex)
            {
                MessageBox.Show(MessageBoxTypes.ERROR, ex.Message);
                //StateHasChanged();
            }
            finally { IsBusy = false; StateHasChanged(); }
        }
    }
}

