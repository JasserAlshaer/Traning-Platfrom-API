using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.OrganizationDTO
{
    public class OrganizationMainInfoDTO
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime YearFounded { get; set; }
        public string TeamSize { get; set; }
        public string? Category { get; set; }
        public int CategoryId { get; set; }
        public string About { get; set; }
    }
}
