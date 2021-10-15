using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Models;

namespace NSSFPensionSystem.Services
{
    interface IClaimService
    {
        Task<ClaimPensionerModel> GetPensioner(string id);

        Task<ClaimModel> Save(ClaimModel data);

        Task<ClaimModel> GetClaim(string id);

        Task<Tuple<List<ClaimModel>, PaginationModel>> GetClaimList(PaginationModel page, string code, string benId, string benName, int psTypeId, int statusId);

        Task<bool> SetClaimApproval(int statusId);
    }
}
