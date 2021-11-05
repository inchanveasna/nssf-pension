﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Setting
{
    public static class APIEndpoint
    {
        public static string BaseUrl { get { return "https://192.168.18.5:443/api/"; } }
        //public static string BaseUrl { get { return "http://localhost:9999/api/"; } }
        //public static string BaseUrl { get { return "http://192.168.18.5/pension/api/"; } }
        //public static string BaseUrl { get { return "http://192.168.201.239/pension/api/api/"; } }

        public static string Menu(int emp_id) { return "get_user_menu?empid=" + emp_id.ToString(); }


        public static string Provinces { get { return "general/province"; } }
        public static string Districts(int pro_id) { return "general/district?proid=" + pro_id.ToString(); }
        public static string Communes(int dis_id) { return "general/commune?disid=" + dis_id.ToString(); }

        public static string ClaimStatus { get { return "general/list/ClaimStatus"; } }
        public static string PensionTypes { get { return "general/list/PensionType"; } }
        public static string Banks { get { return "general/list/Bank"; } }
        public static string Nationalities { get { return "general/list/Nationality"; } }
        public static string Relationships(string sexId) { return "general/list/Relationship?id=" + sexId; }


        public static string Documents { get { return "general/list/Document"; } }
        public static string ClaimPensioner(string id) { return "member/filter/claim?benID=" + id; }


        public static string ClaimSave { get { return "claim/insert"; } }
    }
}
