using NSSFPensionSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Setting;
using AKSoftware.WebApi.Client;
using Newtonsoft.Json;


namespace NSSFPensionSystem.Services.Impl
{
    public class UserService : IUserService
    {
        private IApiService apiService { get; set; }
        private ServiceClient Client;

        public UserService(ServiceClient client)
        {
            this.Client = client;
        }


        public static EmployeeModel Current = new EmployeeModel();

     


        public async Task<EmployeeModel> Get(int empId)
        {
            var response = await Client.GetAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.User(empId));
            if (!response.IsSucceded) throw new Exception(response.Result.Msg);
            else if (response.Result.Error) throw new Exception(response.Result.Msg);
            else if (response.Result.Data == null) throw new Exception(response.Result.Msg);
            else return JsonConvert.DeserializeObject<EmployeeModel>(response.Result.Data.ToString());
        }
    }
}
