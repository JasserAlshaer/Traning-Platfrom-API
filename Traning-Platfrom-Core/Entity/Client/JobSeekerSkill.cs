using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.Entity.Shared;

namespace Traning_Platfrom_Core.Entity.Client
{
    public class JobSeekerSkill : SharedEntity
    {
        
        public virtual JobSeeker JobSeeker { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
