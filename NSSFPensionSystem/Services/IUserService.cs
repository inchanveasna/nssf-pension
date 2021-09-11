using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Models;

namespace NSSFPensionSystem.Services
{
    public interface IUserService
    {
        Task<List<MenuModel>> GetMenus(int emp_id);
    }
}
