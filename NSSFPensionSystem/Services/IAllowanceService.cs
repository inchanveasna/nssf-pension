using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Models;
using NSSFPensionSystem.Models.ViewModels;

namespace NSSFPensionSystem.Services
{
    interface IAllowanceService
    {

        Task<Tuple<List<AllowanceViewModel>, PaginationModel>> GetAllowanceList(PaginationModel page, string code = "", string benid = "", int pstype = 0);

        Task<List<AllowanceReviewViewModel>> GetReview();

        Task<bool> Save(List<PensionAllowanceModel> alws);
    }
}
