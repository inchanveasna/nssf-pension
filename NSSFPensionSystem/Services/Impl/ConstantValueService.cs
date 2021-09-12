using NSSFPensionSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSSFPensionSystem.Setting;

namespace NSSFPensionSystem.Services.Impl
{
    public class ConstantValueService : IConstantValueService
    {
        private ApiService Api { get; set; }

        public ConstantValueService(ApiService apiService)
        {
            this.Api = apiService;
        }

        //public Task<List<BranchModel>> GetBranches()
        //{
        //    throw new NotImplementedException();
        //}

        public Task<List<ProvinceModel>> GetProvices()
        {
            return Api.Get<List<ProvinceModel>>(APIEndpoint.Provinces);
        }

        public Task<List<DistrictModel>> GetDistricts(int pro_id)
        {
            return Api.Get<List<DistrictModel>>(APIEndpoint.Districts(pro_id));
        }

        public Task<List<CommuneModel>> GetCommunes(int disID)
        {
            return Api.Get<List<CommuneModel>>(APIEndpoint.Communes(disID));
        }

        public Task<List<GenderModel>> GetGender()
        {
            List<GenderModel> genders = new List<GenderModel>()
            {
                new GenderModel(){ GenID = "0", GenName = "ស្រី"},
                new GenderModel(){ GenID = "1", GenName = "ប្រុស"}
            };
            return Task.FromResult(genders);
        }
        //public Task<List<PensionType>> GetPensionTypes()
        //{
        //    return apiService.Get<List<PensionType>>(ApiEndpoint.PensionTypes);
        //}
        //public Task<List<FamilyStatus>> GetFamilyStatuses()
        //{
        //    return apiService.Get<List<FamilyStatus>>(ApiEndpoint.FamilyStatus);
        //}
        //public Task<List<Bank>> GetBanks()
        //{
        //    return apiService.Get<List<Bank>>(ApiEndpoint.Banks);
        //}
        public Task<List<NationalityModel>> GetNationalities()
        {
            return Api.Get<List<NationalityModel>>(APIEndpoint.Nationalities);
        }

        public Task<List<RelationshipModel>> GetRelationShips(string sexId)
        {
            return Api.Get<List<RelationshipModel>>(APIEndpoint.Relationships(sexId));
        }
        //public Task<List<HealthStatus>> GetHealthStatuses()
        //{
        //    return apiService.Get<List<HealthStatus>>(ApiEndpoint.HealthStatus);
        //}
        //public Task<List<ClaimStatusModel>> GetClaimStatus()
        //{
        //    return apiService.Get<List<ClaimStatusModel>>(ApiEndpoint.ClaimStatus);
        //}
        public Task<List<DocumentModel>> GetDocuments()
        {
            return Api.Get<List<DocumentModel>>(APIEndpoint.Documents);
        }
        //public Task<Tuple<FilterClaim, string>> GetFilterClaims(string ben_id)
        //{
        //    return apiService.GetWithMessage<FilterClaim>(ApiEndpoint.FilterClaim(ben_id));
        //}
        //public Task<List<OccupationModel>> GetOccupationStatus()
        //{
        //    return apiService.Get<List<OccupationModel>>(ApiEndpoint.OccupationStatus);
        //}
        //public Task<List<SurvivorTypeModel>> GetSurvivorType()
        //{
        //    return apiService.Get<List<SurvivorTypeModel>>(ApiEndpoint.Survivor_Type);
        //}
        //public Task<List<Survivor_ReasonModel>> GetSurvivorReason(int mem_type_id)
        //{
        //    return apiService.Get<List<Survivor_ReasonModel>>(ApiEndpoint.Survivor_Reason(mem_type_id));
        //}
        //public Task<List<EmployeeModel>> GetInvestigator()
        //{
        //    return apiService.Get<List<EmployeeModel>>(ApiEndpoint.Investigator);
        //}
    }
}
