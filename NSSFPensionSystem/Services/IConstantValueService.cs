using NSSFPensionSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Services
{
    public interface IConstantValueService
    {
        Task<DateTime> GetLaunchDate();
        Task<List<ProvinceModel>> GetProvices();
        Task<List<DistrictModel>> GetDistricts(int pro_id);
        Task<List<CommuneModel>> GetCommunes(int disID);
        Task<List<GenderModel>> GetGender();
        //Task<List<BranchModel>> GetBranches();
        Task<List<PensionTypeModel>> GetPensionTypes();
        //Task<List<FamilyStatus>> GetFamilyStatuses();
        Task<List<BankModel>> GetBanks();
        Task<List<CardTypeModel>> GetCardTypes();
        Task<List<NationalityModel>> GetNationalities();
        Task<List<RelationshipModel>> GetRelationShips(string sexId);
        Task<List<FamilyStatusModel>> GetFamilyStatuses();
        //Task<List<HealthStatus>> GetHealthStatuses();
        ////Task<Tuple<FilterClaim, string>> GetFilterClaims(string ben_id);
        Task<List<DocumentModel>> GetDocuments();
        Task<List<ClaimStatusModel>> GetClaimStatus();
        //Task<List<OccupationModel>> GetOccupationStatus();
        //Task<List<SurvivorTypeModel>> GetSurvivorType();
        //Task<List<Survivor_ReasonModel>> GetSurvivorReason(int mem_type_id);
        //Task<List<EmployeeModel>> GetInvestigator();
    }
}
