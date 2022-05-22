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
    public class ConstantValueService : IConstantValueService
    {
        private ApiService Api { get; set; }
        private ServiceClient Client { get; set; }



        public ConstantValueService(ApiService apiService, ServiceClient client)
        {
            this.Api = apiService;
            this.Client = client;
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
        public Task<List<PensionTypeModel>> GetPensionTypes()
        {
            return Api.Get<List<PensionTypeModel>>(APIEndpoint.PensionTypes);
        }

        public Task<List<FamilyStatusModel>> GetFamilyStatuses()
        {
            return Api.Get<List<FamilyStatusModel>>(APIEndpoint.FamilyStatus);
        }
        public Task<List<BankModel>> GetBanks()
        {
            return Api.Get<List<BankModel>>(APIEndpoint.Banks);
        }

        public Task<List<CardTypeModel>> GetCardTypes()
        {
            return Api.Get<List<CardTypeModel>>(APIEndpoint.CardTypes);
        }
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
        public Task<List<ClaimStatusModel>> GetClaimStatus()
        {
            return Api.Get<List<ClaimStatusModel>>(APIEndpoint.ClaimStatus);
        }
        public Task<List<DocumentModel>> GetDocuments()
        {
            return Api.Get<List<DocumentModel>>(APIEndpoint.Documents);
        }

        public async Task<DateTime> GetLaunchDate()
        {
            var res = await Client.GetAsync<ResponseModel>(APIEndpoint.BaseUrl + APIEndpoint.LaunchDate);
            if (!res.IsSucceded) throw new Exception(res.Result.Msg);
            else if (res.Result.Error) throw new Exception(res.Result.Msg);
            else if (res.Result.Data == null) throw new Exception(res.Result.Msg);
            else
            {
                return Convert.ToDateTime(res.Result.Data.ToString());
            }
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
