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
        public List<String> TableHeader = new List<string>() { "ល.រ", "សកម្មភាព", "លេខទាមទារ", "អត្ត. ប.ស.ស.", "គោត្តនាម និងនាម", "ភេទ", "ថ្ងៃខែឆ្នាំកំណើត", "ប្រភេទសោធន", "ស្ថានភាព"};
        public List<ClaimModel> ClaimList = new List<ClaimModel>();
        public List<PensionTypeModel> PensionTypes = new List<PensionTypeModel>();
        public List<ClaimStatusModel> ClaimStatuses = new List<ClaimStatusModel>();
        public PaginationModel Paginate = new PaginationModel();
        #endregion


        protected override async Task OnInitializedAsync()
        {
            var result = await ClaimService.GetClaimList(Paginate);
            this.ClaimList = result.Item1;
            this.Paginate = result.Item2;
            
            this.PensionTypes = await ConstantValue.GetPensionTypes();
            this.ClaimStatuses = await ConstantValue.GetClaimStatus();

            ClaimStatuses.Insert(0, new ClaimStatusModel() { StaId = 0, StaName = "ទាំងអស់", StaDescription = "ទាំងអស់" });
        }


        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            if (firstRender)
            {
                objRef = DotNetObjectReference.Create(this);
                await Runtime.InvokeAsync<object>("CheckAllClaim", objRef);
                StateHasChanged();
            }
        }

        protected void OnAddNew(EventArgs e)
        {
            this.NavigationManager.NavigateTo("claim");
        }

        public void OnEdit(int index)
        {
            string guid = this.ClaimList[index].GUID;
            this.NavigationManager.NavigateTo("claim/" + guid);
        }

        public async void OnPageChanged(PaginationModel paginate)
        {
            var result = await ClaimService.GetClaimList(this.Paginate);
            this.ClaimList = result.Item1;
            this.Paginate = result.Item2;
            StateHasChanged();
        }
        
    }
}
