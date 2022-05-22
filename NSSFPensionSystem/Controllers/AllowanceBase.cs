using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Setting;
using NSSFPensionSystem.Shared.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Models.ViewModels;
using NSSFPensionSystem.Services.Impl;

namespace NSSFPensionSystem.Controllers
{
    public class AllowanceBase : ComponentBase
    {
        #region INJECT
        [Inject]
        private IJSRuntime Runtime { get; set; }

        [Inject]
        private IConstantValueService ConstantValue { get; set; }

        
        [Inject]
        private IAllowanceService AllowanceService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }
        #endregion


        #region PROPERTIES
        //private DotNetObjectReference<ClaimBase> objRef;

        private List<PensionAllowanceModel> PensionAllowances;
        protected List<AllowanceReviewViewModel> AllowanceReviews = new();
        protected List<String> TableHeader = new() { "ល.រ", "លេខទាមទារ", "ប្រភេទសោធន", "លេខអត្ត. បសស", "គោត្តនាម និងនាម", "ភេទ", "ភាគទាន", "ទឹកប្រាក់", "សកម្មភាព" };
        protected Message MessageBox { get; set; }
        protected Loading Loading { get; set; }
        #endregion

       

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {
                await this.OnLoadData();
            }
        }


        private async Task OnLoadData()
        {
            this.Loading.Show();
            this.AllowanceReviews = await AllowanceService.GetReview();
            this.StateHasChanged();
            this.Loading.Close();
        }


        protected async void OnRefresh()
        {
            await this.OnLoadData();
        }

        protected async void OnNavigateToClaim(string id)
        {
            await Runtime.InvokeAsync<object>("open", "claims/" + id, "_blank");
        }


        protected async void OnRemoveClick(int claimId)
        {
            await MessageBox.Show(MessageTypes.CONFIRM, MessageText.REMOVE_CONFIRMATION);
            if (!await MessageBox.IsCancel)
            {
                this.AllowanceReviews.Remove(this.AllowanceReviews.Where(w => w.ClaId == claimId).SingleOrDefault());
                StateHasChanged();
            }
        }


        protected async void OnSave()
        {
            try
            {
                this.Loading.Show();
                this.PensionAllowances = new();

                foreach(var item in this.AllowanceReviews)
                {
                    PensionAllowanceModel alw = new PensionAllowanceModel();
                    alw.Guid = Guid.NewGuid().ToString();
                    alw.ClaId = item.ClaId;
                    alw.PsRate = item.PsRate;
                    alw.NumConMonth = item.NumConYear * 12 + item.NumConMonth;
                    alw.TotalAssumeWage = item.TotalAssumeWage;
                    alw.Active = true;
                    alw.DepId = UserService.Current.DepId;
                    alw.DivId = UserService.Current.DivId;
                    alw.InputBy = UserService.Current.EmpId;
                    alw.Details = new List<PensionAllowanceDetailModel>();

                    foreach(var d in item.Details)
                    {
                        PensionAllowanceDetailModel alwd = new()
                        {
                            AlwTypeId = d.AlwTypeId,
                            PensionAmount = d.PensionAmount,
                            ExtraDay = d.ExtraDay,
                            IsClosed = false,
                        };

                        alw.Details.Add(alwd);
                    }
                    this.PensionAllowances.Add(alw);
                }
                bool saveSuccess = await this.AllowanceService.Save(this.PensionAllowances);
                if (saveSuccess) NavigationManager.NavigateTo("allowance");
            }
            catch(Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }
            finally { this.Loading.Close(); StateHasChanged(); }
        }
    }
}
