using NSSFPensionSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Setting;

namespace NSSFPensionSystem.Services.Impl
{
    public class UserService : IUserService
    {
        private IApiService apiService { get; set; }

        public UserService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public Task<List<MenuModel>> GetMenus(int emp_id)
        {
            return apiService.Get<List<MenuModel>>(APIEndpoint.Menu(emp_id));
        }
    }
}
