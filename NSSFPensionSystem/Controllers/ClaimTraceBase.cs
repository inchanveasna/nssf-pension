using Microsoft.AspNetCore.Components;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Controllers
{
    public class ClaimTraceBase : ComponentBase
    {
        [Inject]
        private IClaimService ClaimService { get; set; }

        [Parameter] 
        public Guid Id { get; set; }

        public List<ClaimTraceModel> Traces = new List<ClaimTraceModel>();




        protected async override Task OnInitializedAsync()
        {
            //this.Trace = await ClaimService.GetClaimTrace()

            await base.OnInitializedAsync();
        }


        protected async override Task OnParametersSetAsync()
        {
            if (Id.ToString().Length == 36 && Id.ToString() != "00000000-0000-0000-0000-000000000000")
            {
                this.Traces = await ClaimService.GetClaimTrace(this.Id.ToString());
            }
            
            await base.OnParametersSetAsync();
        }

        protected string GetClassByClaimStatus(int sta)
        {
            string result = "";
            switch(sta)
            {
                case 1:
                    result = "t-dot-dark";
                    break;
                case 2:
                    result = "t-dot-info";
                    break;
                case 3:
                    result = "t-dot-warning";
                    break;
                case 5:
                    result = "t-dot-primary";
                    break;
                case 4:
                case 6:
                case 8:
                    result = "t-dot-danger";
                    break;
                default:
                    result = "t-dot-success";
                    break; 
            }

            return result;
        }
    }
}
