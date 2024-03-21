using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.JobOpportunity;

using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.Entity.Lookups;
using Traning_Platfrom_Core.Entity.Organization;
using Traning_Platfrom_Core.IRepositaries;
using static Traning_Platfrom_Core.Enums.Enums;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class SharedService : ISharedService
    {
        private readonly TrainingPlatformDbContext _context;
        public SharedService(TrainingPlatformDbContext context)
        {
            _context = context;
        }

        public async Task<List<JobField>> GetJobFieldsAsync()
        {
            var res = await _context.JobFields.ToListAsync();
            return res;
        }

        public async Task<List<JobOpportunityCardDTO>> GetJobOpportunityAsync()
        {
            var res = from job in _context.JobOpportunities
                      join org in _context.Organizations
                      on job.Organization.Id equals org.Id
                      where job.IsDeleted == false
                      orderby job.CreationDate descending
                      select new JobOpportunityCardDTO
                      {
                          Title = job.Title,
                          Description = job.Description,
                          Country = job.Country,
                          City = job.City,
                          Region = job.Region,
                          JobLevel = job.JobLevel.ToString(),
                          JobType = job.JobType.ToString(),
                          OrganizationId = org.Id,
                          OrganizationName = org.Name,
                          OrganizationProfileImage = org.ProfileImage
                      };
            return await res.ToListAsync();
        }

        public async Task<List<OrganizationDTO>> GetOrganizationAsync()
        {
            var res = from org in _context.Organizations
                      where org.IsDeleted == false
                      orderby org.CreationDate descending
                      select new OrganizationDTO
                      {
                          Name = org.Name,
                          Pio = org.Pio,
                          Address = org.Address,
                          Email = org.Email,
                          ProfileImage = org.ProfileImage,
                          PreviewVideoPath = org.PreviewVideoPath,
                          YearFounded = org.YearFounded,
                          GitHubLink = org.GitHubLink,
                          FaceBookLink = org.FaceBookLink,
                          TwitterLink = org.TwitterLink,
                          LinkdeInLink = org.LinkdeInLink
                      };
            return await res.ToListAsync();
        }

        public async Task<List<Skill>> GetSkillsAsync()
        {
            var res = await _context.Skills.ToListAsync();
            return res;
        }
    }
}
