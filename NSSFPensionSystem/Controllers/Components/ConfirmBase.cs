using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Controllers.Components
{
    public class ConfirmBase : ComponentBase
    {
        [Parameter]
        public bool ShowConfirmation { get; set; }

        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }



        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }


        public async Task OnConfirmationChanged(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
