using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Entity.Shared;

namespace Traning_Platfrom_Core.Entity.Company
{
    public class OrganizationAdmin : SharedEntity
    {
        
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Organization> Organizations { get; set; }
    }
}
