using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Client;
using Traning_Platfrom_Core.Entity.Shared;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Entity.Organization
{
    public class JobInterview : SharedEntity
    {
        
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public InterviewType InterviewType { get; set; }
        public virtual JobOpportunity Opportunity { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }

    }
}
