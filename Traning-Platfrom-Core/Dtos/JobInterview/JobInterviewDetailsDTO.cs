using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.JobInterview
{
    public class JobInterviewDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public InterviewType InterviewType { get; set; }
        public string JobOpportunityTitle { get; set; }
        public string JobLevel { get; set; }
        public string JobType { get; set; }
        public string JobSeekerName { get; set; }
        public string JobSeekerEmail { get; set; }
        public string JobSeekerPhone { get; set; }
        public string JobSeekerImage { get; set; }
        public string JobSeekerResume { get; set; }
    }
}
