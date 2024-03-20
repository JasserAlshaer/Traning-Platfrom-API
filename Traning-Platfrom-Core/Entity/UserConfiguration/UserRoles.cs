using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Shared;

namespace Traning_Platfrom_Core.Entity.UserConfiguration
{
    public class UserRoles : SharedEntity
    {
        
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
