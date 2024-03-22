using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.Entity.Shared;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Core.Entity.Client
{
    public class Experience : SharedEntity
    {
        
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public JobLevel JobLevel { get; set; }
        public JobType JobType { get; set; }
        public virtual JobField JobField { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
