using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.JobApplication
{
    public class JobApplicationDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public JobLevel JobLevel { get; set; }
        public JobType JobType { get; set; }
    }
}
