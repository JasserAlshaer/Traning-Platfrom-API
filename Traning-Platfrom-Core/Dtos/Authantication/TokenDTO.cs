using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.Authantication
{
    public class TokenDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string UserType { get; set; }
        public int? OrganizationId { get; set; }
    }
}
