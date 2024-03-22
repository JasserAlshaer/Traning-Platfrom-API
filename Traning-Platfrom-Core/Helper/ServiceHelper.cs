using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Helper
{
    public static class ServiceHelper
    {
        public static float CalaucluateAVG(string gpa,GradingSystem gradingSystem)
        {
            float mygpa = float.Parse(gpa);
            if(gradingSystem == GradingSystem.OutOf4)
            {
                return mygpa/4;
            }else if(gradingSystem == GradingSystem.Outof5)
            {
                return mygpa/5;
            }else
            {
                return mygpa;
            }
        }

        public static float CalaucluateAVG(string gPA, string gradingSystem)
        {
            throw new NotImplementedException();
        }

        public static int CalculateDaysDifference(DateTime startDate, DateTime? endDate)
        {
            DateTime end = endDate ?? DateTime.Now;
            TimeSpan timeSpan = end - startDate;
            return timeSpan.Days;
        }
    }
}
