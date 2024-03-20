using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Organization;
using Traning_Platfrom_Core.Entity.Shared;
using Traning_Platfrom_Core.Entity.UserConfiguration;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Entity.Client
{
    public class JobSeeker : SharedEntity
    {
        
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ProfileBio {  get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public bool IsHaveDrivingLicense { get; set; }
        public string ResumeFilePath { get; set; }
        public string ProfileImagePath { get; set; }
        public virtual List<EducationHistory> EducationHistories { get; set; }
        public virtual List<Experience> Experiences { get; set; }
        public virtual List<JobApplication> JobApplications { get; set; }
        public virtual List<JobInterview> JobInterviews { get; set; }
    }
}
