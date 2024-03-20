using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.Organization;
using Traning_Platfrom_Core.IRepositaries;

namespace Traning_Platfrom_Infra.Repositaries
{
    public class OrganizationService : IOrganizationService
    {
        public Task CompleteOrganizationProfile(CreateOrganizationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateJobInterview(CreateJobInterviewDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateJobOpportunity(CreateJobOpportunityDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJobInterview(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJobOpportunity(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobInterviewDTO>> GetAllJobInterview(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobApplicationDTO>> GetJobApplication()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobApplicationDTO>> GetTopApplicant()
        {
            throw new NotImplementedException();
        }

        public Task UpdateJobInterview(CreateJobInterviewDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJobOpportunity(CreateJobOpportunityDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
