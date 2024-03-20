using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobOpportunity;

using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class SharedService : ISharedService
    {
        public Task<List<JobOpportunityDTO>> GetJobOpportunity()
        {
            throw new NotImplementedException();
        }

        public Task<List<OrganizationDTO>> GetOrganization()
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetSkills()
        {
            throw new NotImplementedException();
        }
    }
}
