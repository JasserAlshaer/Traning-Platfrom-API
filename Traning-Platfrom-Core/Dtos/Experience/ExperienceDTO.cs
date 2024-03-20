using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Dtos.Experience
{
    public class ExperienceDTO
    {
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public JobLevel JobLevel { get; set; }
        public JobType JobType { get; set; }
        public int JobFieldId { get; set; }
        public int JobSeekerId { get; set; }
    }
}
