using AKSoftware.WebApi.Client;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Models.ViewModels;
using NSSFPensionSystem.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Services.Impl
{
    public class AllowanceService : IAllowanceService
    {
        private ServiceClient Client = new ServiceClient();

       public AllowanceService()
        {

        }

        public async Task<Tuple<List<AllowanceViewModel>, PaginationModel>> GetAllowanceList(PaginationModel page, string code = "", string benid = "", int pstype = 0)
        {
            var res = await Client.GetAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.AllowanceList(page.Size.Value, page.Page.Value, code, benid, pstype));
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                PaginationModel p = new PaginationModel() { Page = res.Result.Page, Size = res.Result.Size, Total = res.Result.Total };
                var data = JsonConvert.DeserializeObject<List<AllowanceViewModel>>(res.Result.Data.ToString());
                return Tuple.Create<List<AllowanceViewModel>, PaginationModel>(data, p);
            }
        }

        public async Task<List<AllowanceReviewViewModel>> GetReview()
        {
            var res = await Client.GetAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.AllowanceReview);
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                return JsonConvert.DeserializeObject<List<AllowanceReviewViewModel>>(res.Result.Data.ToString());
            }
        }

        public async Task<bool> Save(List<PensionAllowanceModel> alws)
        {
            var res = await Client.PostAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.Allowance, alws);
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else
            {
                return true;
            }
        }
    }
}
