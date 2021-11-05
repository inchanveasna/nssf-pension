using NSSFPensionSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Setting;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Net.Http.Json;
using Newtonsoft.Json;
using AKSoftware.WebApi.Client;
using System.Net;

namespace NSSFPensionSystem.Services.Impl
{
    public class ClaimService : IClaimService
    {
        private HttpClient HttpClient { get; set; }
        private ServiceClient Client = new ServiceClient();
        
        private ApiService Api { get; set; }

        public ClaimService(ApiService api, HttpClient httpClient)
        {
            this.Api = api;
            this.HttpClient = httpClient;
        }

        public Task<ClaimPensionerModel> GetPensioner(string id)
        {
            return Api.Get<ClaimPensionerModel>(APIEndpoint.ClaimPensioner(id));
        }

        public async Task<ClaimModel> Save(ClaimModel data)
        {
            var response = await Client.PostAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.ClaimSave, data);
            if (!response.IsSucceded) throw new Exception(response.Result.Msg);
            else if (response.Result.Error) throw new Exception(response.Result.Msg);
            else if (response.Result.Data == null) throw new Exception(response.Result.Msg);
            else return JsonConvert.DeserializeObject<ClaimModel>(response.Result.Data.ToString());
        }


        public async Task<Tuple<List<ClaimModel>, PaginationModel>> GetClaimList(PaginationModel page, string code, string benId, string benName, int psTypeId, int statusId)
        {
            string apiURL = string.Format(APIEndpoint.BaseUrl + "claim/claimlist?size={0}&page={1}&pstype={2}&status={3}", page.Size, page.Page, psTypeId, statusId);
            apiURL += code.Trim() == "" ? "" : "&code=" + WebUtility.UrlEncode(code);
            apiURL += benId.Trim() == "" ? "" : "&benid=" + WebUtility.UrlEncode(benId);
            apiURL += benName.Trim() == "" ? "" : "&benname=" + WebUtility.UrlEncode(benName);

            var res = await Client.GetAsync<ResponseModel>(apiURL);
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                PaginationModel p = new PaginationModel() { Page = res.Result.Page, Size = res.Result.Size, Total = res.Result.Total };
                var data = JsonConvert.DeserializeObject<List<ClaimModel>>(res.Result.Data.ToString());
                return Tuple.Create<List<ClaimModel>, PaginationModel>(data, p);
            } 
        }


        public async Task<bool> SetClaimApproval(ClaimTraceModel data)
        {
            var response = await Client.PostAsync<ResponseModel>(APIEndpoint.BaseUrl + "claim/approval", data);
            if (!response.IsSucceded) throw new Exception(response.Result.Msg);
            return !response.Result.Error;
        }



        public async Task<ClaimModel> GetClaim(string id)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("claim/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error API URL!");
            }

            string json = await response.Content.ReadAsStringAsync();
            ResponseModel responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(json);
            if (responseData.Error) throw new Exception(responseData.Msg);
            else if (responseData.Data == null) throw new Exception("NULL");
            else
            {
                ClaimModel c = JsonConvert.DeserializeObject<ClaimModel>(responseData.Data.ToString());
                return c;
            }
        }

        public async Task<List<ClaimTraceModel>> GetClaimTrace(string guid)
        {
            var res = await Client.GetAsync<ResponseModel>(APIEndpoint.BaseUrl + "claim/trace/" + guid);
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                return JsonConvert.DeserializeObject<List<ClaimTraceModel>>(res.Result.Data.ToString());
            }
        }
    }
}
