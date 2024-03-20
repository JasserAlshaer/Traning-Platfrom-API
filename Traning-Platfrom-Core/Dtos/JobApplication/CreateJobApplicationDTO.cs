using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.JobApplication
{
    public class CreateJobApplicationDTO
    {
        public string Note { get; set; }
        public int JobSeekerId { get; set; }
        public int JonOpportunityId {  get; set; }
    }
}
