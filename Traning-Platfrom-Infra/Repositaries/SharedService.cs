using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.JobOpportunity;

using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class SharedService : ISharedService
    {
        private readonly TrainingPlatformDbContext _context;
        public SharedService(TrainingPlatformDbContext context)
        {
            _context = context;
        }

        public Task<List<JobField>> GetJobFieldsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobOpportunityDTO>> GetJobOpportunityAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<OrganizationDTO>> GetOrganizationAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetSkillsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
