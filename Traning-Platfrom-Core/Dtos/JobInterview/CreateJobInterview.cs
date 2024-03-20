using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.JobInterview
{
    public class CreateJobInterview
    {
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public InterviewType InterviewType { get; set; }
        public int JobSeekerId { get; set; }
        public int JonOpportunityId { get; set; }
    }
}
