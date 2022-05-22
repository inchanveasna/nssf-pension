using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Setting
{
    public static class APIEndpoint
    {
        //public static string BaseUrl { get { return "https://192.168.18.5/api/"; } }
       //public static string BaseUrl { get { return "http://localhost:9999/api/"; } }
        public static string BaseUrl { get { return "https://apitest.nssf.gov.kh/pension/api/"; } }
        //public static string BaseUrl { get { return "http://192.168.18.5/pension/api/"; } }
        //public static string BaseUrl { get { return "http://192.168.201.239/pension/api/api/"; } }

        public static string User(int empId) { return "user?empid=" + empId.ToString(); }

        public static string LaunchDate { get { return "general/launch"; } }
        public static string Provinces { get { return "general/province"; } }
        public static string Districts(int pro_id) { return "general/district?proid=" + pro_id.ToString(); }
        public static string Communes(int dis_id) { return "general/commune?disid=" + dis_id.ToString(); }

        public static string ClaimStatus { get { return "general/list/ClaimStatus"; } }
        public static string PensionTypes { get { return "general/list/PensionType"; } }
        public static string FamilyStatus { get { return "general/list/FamilyStatus"; } }
        public static string CardTypes { get { return "general/list/CardType"; } }

        public static string Banks { get { return "general/list/Bank"; } }
        public static string Nationalities { get { return "general/list/Nationality"; } }
        public static string Relationships(string sexId) { return "general/list/Relationship?id=" + sexId; }


        public static string Documents { get { return "general/list/Document"; } }
        public static string ClaimPensioner(string id) { return "member/filter/claim?benID=" + id; }
        public static string ClaimPensionerCon(string id, DateTime effective) { return "member/contribution?benID=" + WebUtility.UrlEncode(id) + "&effective=" + WebUtility.UrlEncode(effective.ToString("yyyy-MM-dd")); }


        public static string ClaimSave { get { return "claim/insert"; } }

        public static string Allowance { get { return "allowance"; } }
        public static string AllowanceList(int size, int page, string code = "", string benid = "", int pstype = 0) 
        { 
            string result = string.Format("allowance/list?page={0}&size={1}", page, size);
            result += code.Length > 0 ? "&code=" + WebUtility.UrlEncode(code) : "";
            result += benid.Length > 0 ? "&benid=" + WebUtility.UrlEncode(benid) : "";
            result += pstype != 0 ? "&pstype=" + pstype : "";
            return result;
        }
        public static string AllowanceReview { get { return "allowance/review"; } }

        public static string PaymentSave { get { return "payment"; } }
        public static string PaymentList { get { return "payment/list"; } }
        public static string PaymentReview { get { return "payment/review"; } }
    }
}
