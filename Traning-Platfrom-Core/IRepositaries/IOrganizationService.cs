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
        Task CompleteOrganizationProfileAsync(CreateOrganizationDTO dto);
        Task CreateJobOpportunityAsync(CreateJobOpportunityDTO dto);
        Task UpdateJobOpportunityAsync(CreateJobOpportunityDTO dto);
        Task DeleteJobOpportunityAsync(int Id);
        Task CreateJobInterviewAsync(CreateJobInterviewDTO dto);
        Task UpdateJobInterviewAsync(CreateJobInterviewDTO dto);
        Task DeleteJobInterviewAsync(int Id);
        Task<List<JobApplicationDetailsDTO>> GetJobApplicationAsync(int Id);
        Task<List<JobApplicationDTO>> GetTopApplicantAsync();
        Task<List<JobInterviewDetailsDTO>> GetAllJobInterviewAsync(int Id);
    }
}
