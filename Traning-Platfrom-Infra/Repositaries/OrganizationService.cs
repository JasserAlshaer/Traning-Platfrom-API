using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Context;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class OrganizationService : IOrganizationService
    {
        private readonly TrainingPlatformDbContext _context;
        public OrganizationService(TrainingPlatformDbContext context)
        {
            _context = context;
        }
        public Task CompleteOrganizationProfileAsync(CreateOrganizationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateJobInterviewAsync(CreateJobInterviewDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateJobOpportunityAsync(CreateJobOpportunityDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJobInterviewAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJobOpportunityAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobInterviewDTO>> GetAllJobInterviewAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobApplicationDTO>> GetJobApplicationAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobApplicationDTO>> GetTopApplicantAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateJobInterviewAsync(CreateJobInterviewDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJobOpportunityAsync(CreateJobOpportunityDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
