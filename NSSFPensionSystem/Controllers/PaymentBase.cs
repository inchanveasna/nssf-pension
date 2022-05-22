using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Models.ViewModels;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Services;
using NSSFPensionSystem.Services.Impl;
using NSSFPensionSystem.Shared.Components;
using Microsoft.JSInterop;


namespace NSSFPensionSystem.Controllers
{
    public class PaymentBase : ComponentBase
    {
        #region INJECT
        [Inject]
        private IJSRuntime Runtime { get; set; }

        [Inject]
        private IPaymentService PaymentService { get; set; }
        #endregion

        protected List<PaymentReviewViewModel> PaymentReviews;
        protected PensionPaymentModel Payment;
        protected List<String> TableHeader = new List<string>() { "ល.រ", "លេខទាមទារ", "ប្រភេទ", "លេខ​ ត.ល", "លេខ​អត្ត. ប.ស.ស.", "សោធនិក", "ធនាគារ", "ទឹកប្រាក់ (៛)", ""};
        protected Loading Loading { get; set; }
        protected Message MessageBox { get; set; }

        protected override void OnInitialized()
        {
            this.PaymentReviews = new List<PaymentReviewViewModel>();
            this.Payment = new PensionPaymentModel() { ForBimonthly = DateTime.Now.Day < 15 ? 1 : 2, ForMonth = DateTime.Now.Month, ForYear = DateTime.Now.Year };
            base.OnInitialized();
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                this.Loading.Show();
                this.PaymentReviews = await this.PaymentService.GetReview();
                StateHasChanged();
                this.Loading.Close();
            }
        }

        protected async void OnNavigateToClaim(string id)
        {
            await Runtime.InvokeAsync<object>("open", "claims/" + id, "_blank");
        }

        protected async void OnSave()
        {
            try
            {
                this.Loading.Show();
                this.Payment.Guid = Guid.NewGuid().ToString();
                this.Payment.DepId = 5;
                this.Payment.DivId = "250";
                this.Payment.InputBy = 2044;
                this.Payment.InputDatetime = DateTime.Now;
                this.Payment.Pensioners = new();
                
                foreach(var d in PaymentReviews)
                {
                    PensionPaymentPensionerModel pensioner = new();
                    pensioner.Guid = Guid.NewGuid().ToString();
                    pensioner.AlwId = d.AlwId;
                    pensioner.ClaId = d.ClaId;
                    pensioner.BankId = d.BankId;
                    pensioner.BankAccount = d.BankAccount;
                    pensioner.TotalAmount = d.Details.Sum(s => s.PensionAmount);
                    pensioner.Details = new();

                    foreach(var dd in d.Details)
                    {
                        PensionPaymentDetailModel detail = new()
                        {
                            AlwTypeId = dd.AlwTypeId,
                            Base = dd.Base,
                            Rate = dd.Rate,
                            Amount = dd.PensionAmount
                        };
                        pensioner.Details.Add(detail);
                    }
                    Payment.Pensioners.Add(pensioner);
                }
                

                Payment = await this.PaymentService.Save(Payment);
            }
            catch(Exception ex)
            {
               await MessageBox.Show(Setting.MessageTypes.ERROR, ex.Message);
            }
            finally 
            {
                StateHasChanged();
                this.Loading.Close();
            }
            
        }

    }
}
