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
            //var request = new HttpRequestMessage(HttpMethod.Post, APIEndpoint.ClaimSave);
            //request.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.ClaimSave, data);
            if (!response.IsSucceded) throw new Exception(response.Result.Msg);
            else if (response.Result.Error) throw new Exception(response.Result.Msg);
            else if (response.Result.Data == null) throw new Exception(response.Result.Msg);
            else return JsonConvert.DeserializeObject<ClaimModel>(response.Result.Data.ToString());
            //if (!response.IsSuccessStatusCode)
            //{
            //    throw new Exception(response.ReasonPhrase);
            //}

            //ResponseModel responseData = await response.Content.ReadFromJsonAsync<ResponseModel>();

            //if (responseData.Error) throw new Exception(responseData.Msg);
            //else if(responseData.Data == null) throw new Exception("NULL");
            //else
            //{
            //    return JsonConvert.DeserializeObject<ClaimModel>(responseData.Data.ToString());
            //}
        }


        public async Task<Tuple<List<ClaimModel>, PaginationModel>> GetClaimList(PaginationModel page)
        {
            var res = await Client.GetAsync<ResponseModel>(string.Format(APIEndpoint.BaseUrl + "claim/claimlist?size={0}&page={1}", page.Size, page.Page));
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                PaginationModel p = new PaginationModel() { Page = res.Result.Page, Size = res.Result.Size, Total = res.Result.Total };
                var data = JsonConvert.DeserializeObject<List<ClaimModel>>(res.Result.Data.ToString());
                return Tuple.Create<List<ClaimModel>, PaginationModel>(data, p);
            } 
                
                
               


            //HttpResponseMessage response = await HttpClient.GetAsync(string.Format("claim/claimlist?size={0}&page={1}", page.Size, page.Page));
            //if(!response.IsSuccessStatusCode)
            //{
            //    throw new Exception("Error API URL!");
            //}

            //string json = await response.Content.ReadAsStringAsync();
            //ResponseModel responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(json);
            //if (responseData.Error) throw new Exception(responseData.Msg);
            //else if (responseData.Data == null) throw new Exception("NULL");
            //else
            //{
            //    return JsonConvert.DeserializeObject<List<ClaimModel>>(responseData.Data.ToString());
            //}
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
    }
}
