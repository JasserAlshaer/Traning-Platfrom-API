using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traning_Platfrom_Core.Dtos.JobApplication;
using Traning_Platfrom_Core.Dtos.JobInterview;
using Traning_Platfrom_Core.Dtos.JobOpportunity;
using Traning_Platfrom_Core.Dtos.JobSeeker.Profile;
using Traning_Platfrom_Core.Dtos.OrganizationDTO;


namespace Traning_Platfrom_Core.IRepositaries
{
    public interface IOrganizationService
    {
        Task CompleteOrganizationProfileAsync(CreateOrganizationDTO dto);
        Task CreateJobOpportunityAsync(JobOpportunityCardDTO dto);
        Task UpdateJobOpportunityAsync(JobOpportunityCardDTO dto);
        Task DeleteJobOpportunityAsync(int Id);
        Task CreateJobInterviewAsync(CreateJobInterviewDTO dto);
        Task UpdateJobInterviewAsync(CreateJobInterviewDTO dto);
        Task DeleteJobInterviewAsync(int Id);
        Task<OrganizationStatisticsDTO> GetOrganizationStatisticsAsync(int Id);
        Task<OrganizationDTO> GetOrganizationDTOAsync(int Id);
        Task<List<JobOpportunityCardDTO>> GetJobOpportunityByOrganizationIdAsync(int Id);
        Task<List<JobApplicationDetailsDTO>> GetJobApplicationAsync(int Id);
        Task<List<JobApplicationDTO>> GetTopApplicantAsync();
        Task<List<JobInterviewDetailsDTO>> GetAllJobInterviewAsync(int Id);
        Task UpdateOrganizationSocialInfoAsync(OrganizationSocialMediaDTO dto);
        Task UpdateOrganizationContactInfoAsync(OrganizationContactDTO dto);
        Task UpdateOrganizationProfileImageAsync(OrganizationProfileImageDTO dto);
        Task UpdateOrganizationMainInfoAsync(OrganizationMainInfoDTO dto);
    }
}
