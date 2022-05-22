using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Models.ViewModels;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Shared.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Controllers
{
    public class AllowanceListBase : ComponentBase
    {
        [Inject] private IJSRuntime Runtime { get; set; }
        [Inject] private IAllowanceService AllowanceService { get; set; }
        [Inject] private IConstantValueService ConstantValue { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        protected List<String> TableHeaders = new() { "ល.រ", "លេខទាមទារ", "ប្រភេទ", "លេខអត្ត. ប.ស.ស.", "គោត្តនាម និងនាម", "ភេទ", "ខែដំបូង(៛)", "ទឹកប្រាក់ប្រាំខែ(៛)", "សកម្មភាព" };
        protected List<PensionTypeModel> PensionTypes = new();
        protected List<AllowanceViewModel> Allowances = new();
        protected PaginationModel Pagination = new();


        protected string SearchAllowanceCode { get; set; } = "";
        protected string SearchClaimCode { get; set; } = "";
        protected string SearchBenId { get; set; } = "";
        protected string SearchBenName { get; set; } = "";
        protected int SearchPensionType { get; set; } = 0;


        protected Message MessageBox { get; set; }
        protected Loading Loading { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.PensionTypes = await ConstantValue.GetPensionTypes();
            PensionTypes.Insert(0, new PensionTypeModel() { TypeId = 0, TypeNameKh = "--ប្រភេទសោធន--" });
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await this.FetchData();
            }
        }


        private async Task FetchData()
        {
            this.Loading.Show();
            this.SearchClaimCode = await Runtime.InvokeAsync<string>("GetMaskCode", "claimcode");
            this.SearchBenId = await Runtime.InvokeAsync<string>("GetMaskPhoneText", "benid");

            var result = await AllowanceService.GetAllowanceList(Pagination, SearchClaimCode, SearchBenId, SearchPensionType);
            this.Allowances = result.Item1;
            this.Pagination = result.Item2;

            StateHasChanged();
            this.Loading.Close();
        }


        protected void OnAddNew(EventArgs e)
        {
            this.NavigationManager.NavigateTo("allowance/new");
        }

        protected async void OnSearchClick(EventArgs e)
        {
            await this.FetchData();
        }

        protected async void OnNavigateToClaim(string id)
        {
            await Runtime.InvokeAsync<object>("open", "claims/" + id, "_blank");
        }

        public async void OnPageChanged(PaginationModel paginate)
        {
            await this.FetchData();
        }
    }
}
