using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.JobApplication
{
    public class JobApplicationDetailsDTO
    {
        public int Id { get; set; }
        public string JobOpportunityTitle { get; set; }
        public string JobLevel { get; set; }
        public string JobType { get; set; }
        public string JobSeekerName { get; set; }
        public string JobSeekerMajor { get; set; }
        public string JobSeekerQulification { get; set; }
        public string JobSeekerEmail { get; set; }
        public string JobSeekerPhone { get; set; }
        public string JobSeekerImage { get; set; }
        public string JobSeekerResume { get; set; }
        public int JobSeekerId { get; set; }
        
    }
}
