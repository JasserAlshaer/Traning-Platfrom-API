using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface ISharedService
    {
        Task GetJobOpportunity();
        Task GetOrganization();
        Task GetSkills();
    }
}
