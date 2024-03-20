using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Client;
using Traning_Platfrom_Core.Entity.Shared;

namespace Traning_Platfrom_Core.Entity.Organization
{
    public class JobApplication : SharedEntity
    {
        
        public string Note { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }    
        public virtual JobOpportunity JobOpportunity { get; set; }  
    }
}
