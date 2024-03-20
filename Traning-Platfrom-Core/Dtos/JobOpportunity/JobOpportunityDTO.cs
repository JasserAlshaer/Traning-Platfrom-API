using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.JobOpportunity
{
    public class JobOpportunityDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Skills { get; set; }
        public string Responsability { get; set; }
        public string JobPrivileges { get; set; }
        public JobLocation JobLocation { get; set; }
        public string OtherApplicationCondition { get; set; }
        //filltering Options 
        public Gender Gender { get; set; }
        public bool IsMustHaveDrivingLicense { get; set; }
        public int MinAmountOfSkills { get; set; }
        public int ExperienceCount { get; set; }
        public float MinGPA { get; set; }
        public EducationCertificationType EducationCertificationType { get; set; }
        public JobLevel JobLevel { get; set; }
        public JobType JobType { get; set; }
        public JobApplicationStatus JobApplicationStatus { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
