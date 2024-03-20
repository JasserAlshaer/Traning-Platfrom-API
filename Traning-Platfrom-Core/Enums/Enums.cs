using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Enums
{
    public class Enums
    {
        public enum JobApplicationStatus
        {
            Available,
            ClosedSoon,
            Closed
        }
        public enum JobType
        {
            Internship,
            PartTime,
            FullTime,
            FreeLancing,
            LimitedContract
        }
        public enum JobLevel
        {
            FreshGraduate,
            Associate,
            Junior,
            Intermediate,
            MidSenior,
            Senior,
            TeamLeader,
            ExecutiveManger,
            AllLevels
        }
        public enum JobPrivileges
        {
            SocialInsurance,
            MedicalInsurance,
            FlexibleWorkingHour,
            Rewards,
            AnnualVacation14Days,
            AnnualVacation20Days,
            AnnualVacation30Days,
            FreeTravelTickets
        }
        public enum NoticePeriod
        {
            None,
            TwoWeeks,
            OneMonth,
            FortyDays,
            TwoMonth
        }
        public enum InterviewType
        {
            OfficeMeeting,
            OnlineMeeting
        }

        public enum JobLocation
        {
            OnSite,
            Hybrid,
            Remote
        }
        public enum Gender
        {
            Male,
            Female,
            Both
        }
        public enum EducationCertificationType
        {
            Course,
            SchollerShip,
            HighSchoolCertificate,
            Bachelor,
            Master,
            PHD,
            Prof
        }
        public enum GradingSystem
        {
            OutOf4,
            OutOf100,
            Outof5
        }
    }
}
