using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using NSSFPensionSystem.Models;
using System.Text.Json.Serialization;
using System.Text;
using System.Text.Json;

namespace NSSFPensionSystem.Services.Impl
{
    public class ApiService : IApiService
    { 
        
        private HttpClient httpClient { get; set; }

        

        public ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }



        public async Task<T> Get<T>(string url)
        {
            //Task task = httpClient.GetAsync(url);
            //var awaiter = task.GetAwaiter();
            ResponseModel responseData = await httpClient.GetFromJsonAsync<ResponseModel>(url);

            //HttpResponseMessage response = await httpClient.GetAsync(url);
            //response.EnsureSuccessStatusCode();
            //string json = response.Content.ReadAsStringAsync().Result;
            //ResponseModel responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(json);
           
            if (responseData.Error || responseData.Data == null)
            {               
                return (T)default;
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseData.Data.ToString());
        }


        public async Task<Tuple<T, string>> GetWithMessage<T>(string url)
        {
            string message = "";
            //Task task = httpClient.GetAsync(url);
            //var awaiter = task.GetAwaiter();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string json = response.Content.ReadAsStringAsync().Result;
            ResponseModel responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(json);

            if (responseData.Error || responseData.Data == null)
            {
                message = responseData.Msg;
                return Tuple.Create((T)default, message);
            }            
            return Tuple.Create(Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseData.Data.ToString()), message);
        }


        public async Task Post(string url, object data)
        {
            //await Task.Run(() =>
            //{
            ////HttpResponseMessage response = await httpClient.PostAsJsonAsync(url, data);
            ////response.EnsureSuccessStatusCode();
            ////string json = response.Content.ReadAsStringAsync().Result;
            ////ResponseModel responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(json);

            ////if (responseData.error) throw new Exception(responseData.msg);
            //});

            // create request object
            var request = new HttpRequestMessage(HttpMethod.Post, url);

            // set request body
            //var postBody = new { Title = "Blazor POST Request Example" };
            request.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented), Encoding.UTF8, "application/json");

            // add authorization header
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "my-token");

            // add custom http header
            //request.Headers.Add("My-Custom-Header", "foobar");

            // send request
            using var response = await httpClient.SendAsync(request);
        }

        public async Task<Tuple<T, string>> PostWithReturn<T>(string url, object data = null)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented), Encoding.UTF8, "application/json");
                var response = await httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

                ResponseModel responseData = await response.Content.ReadFromJsonAsync<ResponseModel>();
                if (responseData.Error || responseData.Data == null)
                {
                    return Tuple.Create((T)default, responseData.Msg);
                }
                return Tuple.Create(Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseData.Data.ToString()), responseData.Msg);
            }
            catch(Exception ex)
            {
                return Tuple.Create((T)default, ex.Message);
            }
        }

        public async Task Put(string url, object data = null)
        {
            // create request object
            var request = new HttpRequestMessage(HttpMethod.Put, url);

            // set request body
            //var postBody = new { Title = "Blazor POST Request Example" };
            request.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented), Encoding.UTF8, "application/json");

            // add authorization header
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "my-token");

            // add custom http header
            //request.Headers.Add("My-Custom-Header", "foobar");

            // send request
            using var response = await httpClient.SendAsync(request);
        }
        public async Task<T> PutWithReturn<T>(string url, object data = null)
        {
            // create request object
            var request = new HttpRequestMessage(HttpMethod.Put, url);

            // set request body
            //var postBody = new { Title = "Blazor POST Request Example" };
            request.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented), Encoding.UTF8, "application/json");

            // add authorization header
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "my-token");

            // add custom http header
            //request.Headers.Add("My-Custom-Header", "foobar");

            // send request
            using var response = await httpClient.SendAsync(request);

            // convert response data to Article object
            ResponseModel responseData = await response.Content.ReadFromJsonAsync<ResponseModel>();

            if (responseData.Error) throw new Exception(responseData.Msg);
            else if (responseData.Data == null) throw new Exception("No data!");

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseData.Data.ToString());
        }
    }
}
