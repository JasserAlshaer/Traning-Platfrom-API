﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobOpportunity;

using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Entity.Lookups;

namespace Traning_Platfrom_Core.IRepositaries
{
    public interface ISharedService
    {
        Task<List<JobOpportunityCardDTO>> GetJobOpportunityAsync();
        Task<List<OrganizationDTO>> GetOrganizationAsync();
        Task<List<Skill>> GetSkillsAsync();
        Task<List<JobField>> GetJobFieldsAsync();
    }
}
