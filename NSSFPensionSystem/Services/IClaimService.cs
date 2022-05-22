using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Models;

namespace NSSFPensionSystem.Services
{
    interface IClaimService
    {
        Task<Tuple<ClaimPensionerModel, string>> GetPensioner(string id);

        Task<List<ContributionModel>> GetPensionerContribution(string benid, DateTime effective);

        Task<ClaimModel> Save(ClaimModel data);

        Task<ClaimModel> GetClaim(string id);

        Task<Tuple<List<ClaimModel>, PaginationModel>> GetClaimList(PaginationModel page, string code, string benId, string benName, int psTypeId, int statusId);

        Task<bool> SetClaimApproval(ClaimTraceModel trace);

        Task<List<ClaimTraceModel>> GetClaimTrace(string guid);
    }
}
