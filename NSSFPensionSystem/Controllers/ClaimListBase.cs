using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Services;
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
        public List<String> TableHeader = new List<string>() { "ល.រ", "លេខទាមទារ", "អត្ត. ប.ស.ស.", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ប្រភេទសោធន", "ស្ថានភាព", "សកម្មភាព" };
        public List<ClaimModel> ClaimList = new List<ClaimModel>();
        public List<PensionTypeModel> PensionTypes = new List<PensionTypeModel>();
        public List<ClaimStatusModel> ClaimStatuses = new List<ClaimStatusModel>();
        public PaginationModel Paginate = new PaginationModel();


        protected string SearchClaimCode { get; set; } = "";
        protected string SearchBenId { get; set; } = "";
        protected string SearchBenName { get; set; } = "";
        protected int SearchPensionType { get; set; } = 0;
        protected int SearchStatus { get; set; } = 0;
        #endregion


        protected override async Task OnInitializedAsync()
        {
            var result = await ClaimService.GetClaimList(Paginate, SearchClaimCode, SearchBenId, SearchBenName, SearchPensionType, SearchStatus);
            this.ClaimList = result.Item1;
            this.Paginate = result.Item2;
            
            this.PensionTypes = await ConstantValue.GetPensionTypes();
            this.ClaimStatuses = await ConstantValue.GetClaimStatus();

            PensionTypes.Insert(0, new PensionTypeModel() { TypeId = 0, TypeNameKh = "--ប្រភេទសោធន--" });
            ClaimStatuses.Insert(0, new ClaimStatusModel() { StaId = 0, StaName = "", StaDescription = "--ស្ថានភាព--" });
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

        protected void OnAddNew(EventArgs e)
        {
            this.NavigationManager.NavigateTo("claim");
        }

        protected void OnSearchClick(EventArgs e)
        {
            this.FetchData();
        }

        public void OnEdit(int index)
        {
            string guid = this.ClaimList[index].GUID;
            this.NavigationManager.NavigateTo("claim/" + guid);
        }

        public void OnApproval(int statusID)
        {

        }

        private async void FetchData()
        {
            this.SearchClaimCode = await Runtime.InvokeAsync<string>("GetMaskCode", "claimcode");

            var result = await ClaimService.GetClaimList(Paginate, SearchClaimCode, SearchBenId, SearchBenName, SearchPensionType, SearchStatus);
            this.ClaimList = result.Item1;
            this.Paginate = result.Item2;
            StateHasChanged();
        }

        public async void OnPageChanged(PaginationModel paginate)
        {
            this.FetchData();
        }
        
    }
}
