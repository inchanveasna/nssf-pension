using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Setting;
using NSSFPensionSystem.Shared.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Controllers
{
    public class ClaimListBase : ComponentBase
    {
        #region
        [Inject]
        private IJSRuntime Runtime { get; set; }

        [Inject]
        private IClaimService ClaimService { get; set; }

        [Inject]
        private IConstantValueService ConstantValue { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }
        #endregion

        #region PROPERTIES
        private DotNetObjectReference<ClaimListBase> objRef;
        public List<String> TableHeader = new List<string>() { "ល.រ", "លេខទាមទារ", "ប្រភេទ", "អត្ត. ប.ស.ស.", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ស្ថានភាព", "សកម្មភាព" };
        public List<ClaimModel> ClaimList = new List<ClaimModel>();
        public ClaimTraceModel ClaimTrace = new ClaimTraceModel();
        public List<PensionTypeModel> PensionTypes = new List<PensionTypeModel>();
        public List<ClaimStatusModel> ClaimStatuses = new List<ClaimStatusModel>();
        public List<ClaimTraceModel> Traces = new List<ClaimTraceModel>();
        public PaginationModel Paginate = new PaginationModel();


        protected string SearchClaimCode { get; set; } = "";
        protected string SearchBenId { get; set; } = "";
        protected string SearchBenName { get; set; } = "";
        protected int SearchPensionType { get; set; } = 0;
        protected int SearchStatus { get; set; } = 0;


        public Message MessageBox { get; set; }
        public Loading Loading { get; set; }
        public Modal ApprovalNoteModal { get; set; }
        public Modal TraceModal { get; set; }

        private int SelectedIndex = -1;
        private int SelectedStatus = -1;
        #endregion




        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            
            if (firstRender)
            {
                Loading.Show();
                var result = await ClaimService.GetClaimList(Paginate, SearchClaimCode, SearchBenId, SearchBenName, SearchPensionType, SearchStatus);
                this.ClaimList = result.Item1;
                this.Paginate = result.Item2;

                this.PensionTypes = await ConstantValue.GetPensionTypes();
                this.ClaimStatuses = await ConstantValue.GetClaimStatus();

                PensionTypes.Insert(0, new PensionTypeModel() { TypeId = 0, TypeNameKh = "--ប្រភេទសោធន--" });
                ClaimStatuses.Insert(0, new ClaimStatusModel() { StaId = 0, StaName = "", StaDescription = "--ស្ថានភាព--" });



                objRef = DotNetObjectReference.Create(this);
                await Runtime.InvokeAsync<object>("ClaimJS", objRef);
                //await Runtime.InvokeAsync<object>("InitDatatable", "#tableClaimList");
                StateHasChanged();
            }

            Loading.Close();
            base.OnAfterRender(firstRender);
        }


        public void OnMessageBoxConfirmation(bool result, ConfirmFor confirmFor)
        {
            if (result)
            {
                if (confirmFor == ConfirmFor.CLAIM_DOCUMENT)
                {
                    
                }
            }
            StateHasChanged();
        }

        protected void OnAddNew(EventArgs e)
        {
            this.NavigationManager.NavigateTo("claims/new");
        }

        protected void OnSearchClick(EventArgs e)
        {
            this.FetchData();
        }

        public void OnEdit(int index)
        {
            string guid = this.ClaimList[index].GUID;
            this.NavigationManager.NavigateTo("claims/" + guid);
        }

        
        public async Task Approval()
        {
            try
            {
                ClaimModel claim = ClaimList[this.SelectedIndex];
                ClaimTrace.ClaimId = claim.ClaId;
                ClaimTrace.StatusId = (byte)this.SelectedStatus;
                ClaimTrace.DivId = "250";
                ClaimTrace.InputBy = 2044;
                ClaimTrace.InputDatetime = DateTime.Now;
                
                bool result = await ClaimService.SetClaimApproval(this.ClaimTrace);
                if (result)
                {
                    claim.StatusId = this.SelectedStatus;
                    ClaimList[this.SelectedIndex] = claim;
                    await this.ApprovalNoteModal.Close();
                    await MessageBox.Show(Setting.MessageTypes.INFO, "Successfully!");
                }
            }
            catch (Exception ex) {await MessageBox.Show(MessageTypes.ERROR, ex.Message); }
            finally { StateHasChanged(); }
        }



        public async Task OnApproval(int index, int statusID)
        {
           try
            {
                int[] rejectStatus = {4, 6, 8 };
                this.SelectedIndex = index;
                this.SelectedStatus = statusID;

                if(rejectStatus.Contains(statusID)) this.ApprovalNoteModal.Open();
                else await Approval();
            }
            catch(Exception ex) { await MessageBox.Show(MessageTypes.ERROR, ex.Message); }
            finally { StateHasChanged(); }
        }


        public async Task OnApprovalRejected()
        {
            try
            {
                if (ClaimTrace.Note.Trim().Length == 0)
                {
                    await MessageBox.Show(MessageTypes.WARNING, "សូមបញ្ចូលមូលហេតុ!");
                    return;
                }
                await Approval();
            }
            catch (Exception ex) { await MessageBox.Show(MessageTypes.ERROR, ex.Message); }
            finally { StateHasChanged(); }
        }


        public async Task OnShowTrace(int index)
        {
            try
            {
                this.Traces = await ClaimService.GetClaimTrace(this.ClaimList[index].GUID);
                this.TraceModal.Open();   
            }
            catch (Exception ex) { await MessageBox.Show(MessageTypes.ERROR, ex.Message); }
            finally { StateHasChanged(); }
        }


        private async void FetchData()
        {
            Loading.Show();
            this.SearchClaimCode = await Runtime.InvokeAsync<string>("GetMaskCode", "claimcode");
            this.SearchBenId = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "benid");

            var result = await ClaimService.GetClaimList(Paginate, SearchClaimCode, SearchBenId.Replace("_", ""), SearchBenName, SearchPensionType, SearchStatus);
            this.ClaimList = result.Item1;
            this.Paginate = result.Item2;
            StateHasChanged();
            Loading.Close();
        }

        public void OnPageChanged(PaginationModel paginate)
        {
            this.FetchData();
        }
        
    }
}
