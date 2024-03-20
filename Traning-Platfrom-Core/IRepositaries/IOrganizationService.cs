using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;


namespace Traning_Platfrom_Core.IRepositaries
{
    public interface IOrganizationService
    {
        Task CompleteOrganizationProfile(CreateOrganizationDTO dto);
        Task CreateJobOpportunity(CreateJobOpportunityDTO dto);
        Task UpdateJobOpportunity(CreateJobOpportunityDTO dto);
        Task DeleteJobOpportunity(int Id);
        Task CreateJobInterview(CreateJobInterviewDTO dto);
        Task UpdateJobInterview(CreateJobInterviewDTO dto);
        Task DeleteJobInterview(int Id);
        Task<List<JobApplicationDTO>> GetJobApplication();
        Task<List<JobApplicationDTO>> GetTopApplicant();
        Task<List<JobInterviewDTO>> GetAllJobInterview(int Id);
    }
}
