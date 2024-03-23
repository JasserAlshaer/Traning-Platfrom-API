using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Company;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.JobOpportunity
{
    public class JobOpportunityDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        //filltering Options 
        public string JobLocation { get; set; }
        public string Gender { get; set; }
        public bool IsMustHaveDrivingLicense { get; set; }
        public int MinAmountOfSkills { get; set; }
        public int ExperienceCount { get; set; }
        public float MinGPA { get; set; }
        public string EducationCertificationType { get; set; }
        public string JobLevel { get; set; }
        public string JobType { get; set; }
        public string JobField { get; set; }
        public string JobApplicationStatus { get; set; }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationProfileImage { get; set; }
        public DateTime PublishedDate { get; set; }
        //Lists
        public string SkillsString { get; set; }
        public string ResponsabilityString { get; set; }
        public string JobPrivilegesString { get; set; }
        public string OtherApplicationConditionString { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Responsability { get; set; }
        public List<string> JobPrivileges { get; set; }
        public List<string> OtherApplicationCondition { get; set; }
    }
}
