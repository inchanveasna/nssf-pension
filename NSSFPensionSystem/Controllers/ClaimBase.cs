using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Services.Impl;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Shared.Components;
using NSSFPensionSystem.Setting;
using Newtonsoft.Json;
using NSSFPensionSystem.Pages.Claim;

namespace NSSFPensionSystem.Controllers
{
    public class ClaimBase : ComponentBase
    {
        [Parameter] public Guid Id { get; set; }


        #region INJECT
        [Inject] private IJSRuntime Runtime { get; set; }
        [Inject] private IConstantValueService ConstantValue { get; set; }
        [Inject] private IUserService User { get; set; }
        [Inject] private IClaimService ClaimService { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        #endregion



        #region PROPERTIES
        private DotNetObjectReference<ClaimBase> JsRef;
        protected bool Disabled = true;
        protected ClaimModel Claim = new ClaimModel();
        private ClaimModel BackupClaim = new ClaimModel();
        protected List<NationalityModel> Nationalities = new();
        protected List<DocumentModel> Documents = new();
        protected List<ProvinceModel> Provinces = new();
        protected List<DistrictModel> Districts = new();
        protected List<CommuneModel> Communes = new();
        protected List<GenderModel> Genders = new();
        protected List<RelationshipModel> Relationships = new();
        protected List<BankModel> Banks = new();
        protected List<PensionTypeModel> PensionTypes = new();
        protected List<FamilyStatusModel> FamilyStatus = new();
        protected List<CardTypeModel> CardTypes = new();



        protected List<String> TableHeaderDocument = new List<string>() { "ល.រ", "ប្រភេទឯកសារ", "លេខលិខិត", "ថ្ងៃខែឆ្នាំចុះលិខិត", "ចេញលិខិតដោយ", "ចេញលិខិតនៅ", "កែប្រែ" };
        protected List<String> TableHeaderMember = new List<string>() { "ល.រ", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ត្រូវជា", "សញ្ជាតិ", "លេខទូរស័ព្ទ", "កែប្រែ" };


        protected ClaimDocumentModal ModalClaimDocument { get; set; }
        protected ClaimFamilyModal ModalMember { get; set; }
        protected Message MessageBox { get; set; }
        protected Loading Loading { get; set; }

        protected bool btnEditDisabled = false;
        private FormMode _formMode;
        protected FormMode FormMode
        {
            get { return _formMode; }
            set
            {
                _formMode = value;
                if (_formMode == FormMode.EDITABLE)
                {
                    Disabled = false;
                    btnEditDisabled = false;
                }
                else if(_formMode == FormMode.VIEW)
                {
                    Disabled = true;
                    btnEditDisabled = false;
                }
                else if(_formMode == FormMode.NEW)
                {
                    Disabled = true;
                    btnEditDisabled = false;
                }
                else if(_formMode == FormMode.UNEDITABLE)
                {
                    Disabled = true;
                    btnEditDisabled = true;
                }
            }
        }
        #endregion




        protected override Task OnParametersSetAsync()
        {
            this.Claim = new ClaimModel();
            return base.OnParametersSetAsync();
        }


        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                this.Loading.Show();
                this.Nationalities = await ConstantValue.GetNationalities();
                this.Documents = await ConstantValue.GetDocuments();
                this.Genders = await ConstantValue.GetGender();
                this.Banks = await ConstantValue.GetBanks();
                this.PensionTypes = await ConstantValue.GetPensionTypes();
                this.FamilyStatus = await ConstantValue.GetFamilyStatuses();
                this.CardTypes = await ConstantValue.GetCardTypes();

                
                this.Provinces = await ConstantValue.GetProvices();
                if (this.Provinces != null && this.Provinces.Count > 0)
                {
                    this.Districts = await ConstantValue.GetDistricts(this.Provinces[0].ProID);
                    if (this.Districts != null && this.Districts.Count > 0)
                    {
                        await OnDistrictChange(this.Districts.FirstOrDefault().DisID);
                    }
                }

                if (Id.ToString().Length == 36 && Id.ToString() != "00000000-0000-0000-0000-000000000000")
                {
                    this.Claim = await ClaimService.GetClaim(Id.ToString());
                    await this.OnProvinceChanged(this.Claim.ProId);
                    await this.OnDistrictChange(this.Claim.DisId);
                    this.FormMode = Claim.StatusId == 1 || Claim.StatusId == 4 ? FormMode.UNEDITABLE : FormMode.VIEW;
                }


                this.JsRef = DotNetObjectReference.Create(this);
                await Runtime.InvokeAsync<object>("ClaimJS", JsRef);
                StateHasChanged();
            }


            this.Loading.Close();
            base.OnAfterRender(firstRender);
        }

    

        [JSInvokable]
        public async void OnPensionTypeChanged(object e)
        {
            Claim.ElderlyRegulation = await this.IsElderlyRegulation();
            StateHasChanged();
        }

        [JSInvokable]
        public async void OnBenIdCompleted(object e)
        {
            try
            {
                Loading.Show();
                string benId = e.ToString();
                var tuple = await ClaimService.GetPensioner(benId);
                ClaimPensionerModel pensioner = tuple.Item1;
                Loading.Close();

                if (pensioner == null)
                {
                    await MessageBox.Show(MessageTypes.WARNING, MessageText.NO_DATA);
                    StateHasChanged();
                    return;
                }
                else if(!string.IsNullOrEmpty(tuple.Item2))
                {
                    await MessageBox.Show(MessageTypes.WARNING, tuple.Item2);
                    StateHasChanged();
                }


                Claim.BenId = benId;
                Claim.Pensioner = pensioner;
                Claim.EffectiveDate = Utils.CalAge(pensioner.Dob.Value, DateTime.Now).Item1 >= 60 ? DateTime.Now : pensioner.Dob.Value.AddYears(60).Date;
                Claim.Pensioner.Contributions = await ClaimService.GetPensionerContribution(Claim.BenId, Claim.EffectiveDate.Value);
                Claim.ElderlyRegulation = await this.IsElderlyRegulation();
                Claim.FamilyStatusId = pensioner.FamilyStatusId;
                Claim.IdType = pensioner.IdType;
                Claim.IdNumber = pensioner.IdCard;
                Claim.NationalId = pensioner.NationalityId;
                Claim.Phone1 = pensioner.Phone;
                Claim.NumConMonth = pensioner.Contributions.Count();
                Claim.TotalAssumeWage = Convert.ToInt32(pensioner.Contributions.Sum(s => s.AssumeWage));
                Claim.ProId = pensioner.ProId;
                await this.OnProvinceChanged(this.Claim.ProId);
                Claim.DisId = pensioner.DisId;
                await this.OnDistrictChange(this.Claim.DisId);
                Claim.ComId = pensioner.ComId;
                Claim.Village = pensioner.Village;
                Claim.Home = pensioner.Home;
                Claim.Street = pensioner.Street;
                
                StateHasChanged();
            }
            catch(Exception ex)
            {
                await MessageBox.Show(MessageTypes.ERROR, ex.Message);
                StateHasChanged();
            }
        }

        private async Task<bool> IsElderlyRegulation()
        {
            bool result = false;
            DateTime launchDate = await ConstantValue.GetLaunchDate();
            if(Claim.PsTypeId == 1 && Claim.NumConMonth >= 24 && Claim.EffectiveDate <= launchDate.AddYears(3))
            {
                result = true;
            }

            return result;
        }

        [JSInvokable]
        public async void OnBenIdInCompleted(object e)
        {
            Claim.Pensioner = new ClaimPensionerModel();
            Claim.EffectiveDate = null;
            Claim.IdNumber = "";
            Claim.Phone1 = "";
            Claim.NumConMonth = 0;
            Claim.TotalAssumeWage = 0;
            Claim.ProId = -1;
            await this.OnProvinceChanged(this.Claim.ProId);
            Claim.DisId = -1;
            Claim.ComId = -1;
            Claim.Village = "";
            Claim.Home = "";
            Claim.Street = "";
            StateHasChanged();
        }


        [JSInvokable]
        public async Task OnProvinceChanged(object val)
        {
            if (val == null) return;
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
            this.StateHasChanged();
        }

     
        public async void OnClaimDocumentModalSubmit(int index, ClaimDocumentModel doc)
        {
            int countCheck = Claim.Documents.Where(w => w.DocID == doc.DocID).Count();
            //ADD 
            if (index == -1 && countCheck == 0)
            {
                Claim.Documents.Add(doc);
                await ModalClaimDocument.Close();
            }
            //UPDATE
            else if (index >= 0 && countCheck == 1)
            {
                Claim.Documents.RemoveAt(index);
                Claim.Documents.Insert(index, doc);
                await ModalClaimDocument.Close();
            }
            else await MessageBox.Show(MessageTypes.WARNING, "ប្រភេទឯកសារនេះធ្លាប់បានបញ្ចូលរួចហើយ!");
            StateHasChanged();
        }

        public async void OnMemberModalSubmit(int index, ClaimFamilyMemberModel member)
        {
            List<string> validatMsg = new List<string>();
            if (member.FirstNameKh.Trim().Length == 0 || member.LastNameKh.Trim().Length == 0)
                validatMsg.Add("- សូមបញ្ចូលគោត្តនាម និងនាមឲ្យបានត្រឹមត្រូវ!");
            else if (member.Dob == null)
                validatMsg.Add("- សូមបញ្ចូលថ្ងៃខែឆ្នាំកំណើតឲ្យបានត្រឹមត្រូវ!");

            if (validatMsg.Count > 0)
            {
                await MessageBox.Show(MessageTypes.WARNING, string.Join("\n", validatMsg));
                return;
            }


            if (index == -1)
            {
                this.Claim.Members.Add(member);
            }
            else
            {
                this.Claim.Members.RemoveAt(index);
                this.Claim.Members.Insert(index, member);
            }

            await this.ModalMember.Close();
        }


        public async Task OnRemoveClaimDocument(int index)
        {
            await MessageBox.Show(MessageTypes.CONFIRM, MessageText.REMOVE_CONFIRMATION);
            if (!await MessageBox.IsCancel)
            {
                this.Claim.Documents.RemoveAt(index);
                StateHasChanged();
            }
        }


        public async void OnRemoveMember(int index)
        {
            await MessageBox.Show(MessageTypes.CONFIRM, MessageText.REMOVE_CONFIRMATION);
            if (!await MessageBox.IsCancel)
            {
                this.Claim.Members.RemoveAt(index);
                StateHasChanged();
            }
        }

        public void OnEdit(EventArgs e)
        {
            if (Disabled)
            {
                this.FormMode = FormMode.EDITABLE;
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(this.Claim);
                this.BackupClaim = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimModel>(json);
            }
            else
            {
                this.FormMode = FormMode.VIEW;
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(this.BackupClaim);
                this.Claim = Newtonsoft.Json.JsonConvert.DeserializeObject<ClaimModel>(json);
            }
            StateHasChanged();
        }

        public async void OnSave(EventArgs e)
        {
            try
            {
                this.Loading.Show();
                if (Claim.ClaId == 0)
                {
                    Claim.GUID = Guid.NewGuid().ToString();

                }
                Claim.EntId = Claim.Pensioner.Contributions.Select(s => new { s.EntId }).Distinct().Count() == 1 ? Claim.Pensioner.Contributions.FirstOrDefault().EntId : Claim.EntId;
                //Claim.NationalId = Claim.Pensioner.NationalityId;
                //Claim.IdNumber = Claim.Pensioner.IdCard;
                Claim.Phone1 = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "phone1");
                Claim.Phone2 = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "phone2");
                Claim.DepId = UserService.Current.DepId;
                Claim.DivId = UserService.Current.DivId;
                Claim.InputBy = Claim.ClaId == 0 ? UserService.Current.EmpId : Claim.InputBy;
                if (Claim.ClaId != 0) Claim.EditBy = UserService.Current.EmpId;

                var result = await ClaimService.Save(Claim);
                Claim = JsonConvert.DeserializeObject<ClaimModel>(JsonConvert.SerializeObject(result));

                await MessageBox.Show(MessageTypes.INFO, MessageText.SUCCESS);
                StateHasChanged();
            }
            catch(Exception ex)
            {
                await MessageBox.Show(MessageTypes.ERROR, ex.Message);
            }
            finally { this.Loading.Close(); StateHasChanged(); }
        }
    }
}

