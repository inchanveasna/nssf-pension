using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using Newtonsoft.Json;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Models.ViewModels;
using NSSFPensionSystem.Setting;

namespace NSSFPensionSystem.Services.Impl
{
    public class PaymentService : IPaymentService
    {

        private ServiceClient Client = new ServiceClient();

        public PaymentService(ServiceClient client)
        {
            this.Client = client;
        }

        public async Task<List<PaymentReviewViewModel>> GetReview()
        {
            var res = await Client.GetAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.PaymentReview);
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                return JsonConvert.DeserializeObject<List<PaymentReviewViewModel>>(res.Result.Data.ToString());
            }
        }

        public async Task<PensionPaymentModel> Save(PensionPaymentModel data)
        {
            var response = await Client.PostAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.PaymentSave, data);
            if (!response.IsSucceded) throw new Exception(response.Result.Msg);
            else if (response.Result.Error) throw new Exception(response.Result.Msg);
            else if (response.Result.Data == null) throw new Exception(response.Result.Msg);
            else return JsonConvert.DeserializeObject<PensionPaymentModel>(response.Result.Data.ToString());
        }


        public async Task<List<PensionPaymentModel>> GetList()
        {
            var res = await Client.GetAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.PaymentList);
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                return JsonConvert.DeserializeObject<List<PensionPaymentModel>>(res.Result.Data.ToString());
            }
        }
    }
}
