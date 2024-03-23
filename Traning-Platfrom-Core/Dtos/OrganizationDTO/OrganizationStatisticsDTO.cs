using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.OrganizationDTO
{
    public class OrganizationStatisticsDTO
    {
        public int Jobs          { get; set; }
        public int Applications { get; set; }
        public int Interview      {   get; set; }
        public int Notifications { get; set; }
    }
}
