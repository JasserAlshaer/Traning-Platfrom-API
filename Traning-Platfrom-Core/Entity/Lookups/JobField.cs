using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Company;
using Traning_Platfrom_Core.Entity.Shared;


namespace Traning_Platfrom_Core.Entity.Lookups
{
    public class JobField : SharedEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public virtual List<Organization> Organizations { get; set; }
        public virtual List<JobOpportunity> JobOpportunities { get; set; }  
    }
}
