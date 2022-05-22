using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Setting
{
    public class Utils
    {
        public static Tuple<int, int, int> CalAge(DateTime Dob, DateTime DateVal)
        {
            int Years = new DateTime(DateVal.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == DateVal)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= DateVal)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = DateVal.Subtract(PastYearDate.AddMonths(Months)).Days;
            //int Hours = DateVal.Subtract(PastYearDate).Hours;
            //int Minutes = DateVal.Subtract(PastYearDate).Minutes;
            //int Seconds = DateVal.Subtract(PastYearDate).Seconds;

            //string AgeMonths = nssfRef.nssfMethod.f_convertNumToKH(Months.ToString());
            //string AgeDays = nssfRef.nssfMethod.f_convertNumToKH(Days.ToString());

            //AgeMonths = AgeMonths.Length == 1 ? "០" + AgeMonths : AgeMonths;
            //AgeDays = AgeDays.Length == 1 ? "០" + AgeDays : AgeDays;

            return Tuple.Create<int, int, int>(Years, Months, Days);
        }
    }
}
