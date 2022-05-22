using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Models.ViewModels;
using NSSFPensionSystem.Models;

namespace NSSFPensionSystem.Services
{
    interface IPaymentService
    {
        Task<List<PaymentReviewViewModel>> GetReview();

        Task<PensionPaymentModel> Save(PensionPaymentModel model);


        Task<List<PensionPaymentModel>> GetList();
    }
}
