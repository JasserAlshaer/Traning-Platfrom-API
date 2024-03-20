using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Shared;

namespace Traning_Platfrom_Core.Entity.UserConfiguration
{
    public class Role : SharedEntity
    {
        public string Name { get; set; }
        public string NameAR { get; set; }
        public string Description { get; set; }
    }
}
